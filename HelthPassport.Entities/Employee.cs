using HelthPassport.Entities.Bases;
using HelthPassport.Entities.Enums;

namespace HelthPassport.Entities
{
    public class Employee : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<EmployeeMoving> Moving { get; set; } = new List<EmployeeMoving>();
        public List<Femily> Femilies { get; set; } = new List<Femily>();
        public List<Change> Changes { get; set; } = new List<Change>();
        public List<Disease> Diseases { get; set; } = new List<Disease>();

        public Employee(
            Guid id = default,
            string firstName = null,
            string middleName = null,
            string lastName = null,
            GenderEnum gender = default,
            DateTime birthDay = default,
            List<Education> educations = null,
            List<EmployeeMoving> moving = null,
            List<Femily> femilies = null,
            List<Change> changes = null,
            List<Disease> diseases = null)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            BirthDay = birthDay;
            Educations = educations;
            Moving = moving;
            Femilies = femilies;
            Changes = changes;
            Diseases = diseases;
        }

        public Education? GetCurrentEdication()
        {
            if (Educations.Count == 0)
            {
                return null;
            }

            var sortedEducations = Educations
                .OrderByDescending(education => education.Level)
                .ToList();

            return sortedEducations[0];
        }

        public Femily GetCurrentFemily()
        {
            if (Femilies.Count == 0)
            {
                return null;
            }

            var sortedEducations = Femilies
                .OrderByDescending(femily => femily.Start)
                .ToList();

            return sortedEducations[0];
        }

        public FemilyStatusEnum GetFemilyStatus()
        {
            Femily femily = GetCurrentFemily();
            
            if (femily is null)
            {
                return FemilyStatusEnum.Single;
            }

            if (femily.End.HasValue)
            {
                return FemilyStatusEnum.Divoced;
            }

            return FemilyStatusEnum.Married;
        }

        public string GetFullName()
            => FirstName + " " + MiddleName + " " + LastName;
        
        public int GetAge()
            => (int)(DateTime.Now.Subtract(BirthDay).TotalDays / 365.25);        
    }
}
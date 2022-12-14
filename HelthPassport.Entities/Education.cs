using HelthPassport.Entities.Bases;
using HelthPassport.Entities.Enums;

namespace HelthPassport.Entities
{
    public class Education : EntityBase<Guid>
    {
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Document { get; set; }
        public EducationEnum Level { get; set; }

        public Education(
            Guid id = default,
            DateTime date = default,
            string company = null,
            string document = null,
            EducationEnum level = default)
        {
            Id = id;
            Date = date;
            Company = company;
            Document = document;
            Level = level;
        }
    }
}
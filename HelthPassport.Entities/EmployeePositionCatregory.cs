using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class EmployeePositionCatregory : EntityBase<Guid>
    {
        public string Name { get; set; }

        public EmployeePositionCatregory(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }
    }
}
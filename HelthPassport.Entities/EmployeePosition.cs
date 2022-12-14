using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class EmployeePosition : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public EmployeePositionCatregory Category { get; set; }

        public EmployeePosition(
            Guid id = default,
            string name = null,
            Guid categoryId = default,
            EmployeePositionCatregory category = null)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Category = category;
        }
    }
}
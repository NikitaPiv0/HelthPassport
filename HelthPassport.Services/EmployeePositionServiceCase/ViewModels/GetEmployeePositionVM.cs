using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeePositionServiceCase.ViewModels
{
    public class GetEmployeePositionVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public GetEmployeePositionVM(
            Guid id = default,
            string name = null,
            Guid categoryId = default,
            string categoryName = null)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public GetEmployeePositionVM(EmployeePosition position)
        {
            Id = position.Id;
            Name = position.Name;
            CategoryId = position.CategoryId;
            CategoryName = position.Category.Name;
        }
    }
}
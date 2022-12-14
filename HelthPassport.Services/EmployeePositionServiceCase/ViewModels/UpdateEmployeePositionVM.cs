using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeePositionServiceCase.ViewModels
{
    public class UpdateEmployeePositionVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }

        public UpdateEmployeePositionVM(
            Guid id = default,
            string name = null,
            Guid categoryId = default)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
        }
    }
}
using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeePositionCatregoryServiceUseCase.ViewModels
{
    public class UpdateEmployeePositionCatregoryVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public UpdateEmployeePositionCatregoryVM(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }

        public UpdateEmployeePositionCatregoryVM(EmployeePositionCatregory category)
        {
            Id = category.Id;
            Name = category.Name;
        }
    }
}
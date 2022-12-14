using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeePositionCatregoryServiceUseCase.ViewModels
{
    public class CreateEmployeePositionCatregoryVM
    {
        public string Name { get; set; }

        public CreateEmployeePositionCatregoryVM(string name = null)
            => Name = name;

        public CreateEmployeePositionCatregoryVM(EmployeePositionCatregory category)
            => Name = category.Name;
    }
}
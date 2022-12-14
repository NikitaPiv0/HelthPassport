using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeePositionCatregoryServiceUseCase.ViewModels
{
    public class GetEmployeePositionCatregoryVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public GetEmployeePositionCatregoryVM(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }

        public GetEmployeePositionCatregoryVM(EmployeePositionCatregory category)
        {
            Id = category.Id;
            Name = category.Name;
        }
    }
}
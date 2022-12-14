using HelthPassport.Entities;

namespace HelthPassport.Services.DivisionServiceUseCase.ViewModels
{
    public class GetDivisionVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public GetDivisionVM(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }
        
        public GetDivisionVM(Division division)
        {
            Id = division.Id;
            Name = division.Name;
        }
    }
}
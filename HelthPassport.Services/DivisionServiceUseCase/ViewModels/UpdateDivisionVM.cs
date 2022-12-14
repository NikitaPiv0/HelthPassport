namespace HelthPassport.Services.DivisionServiceUseCase.ViewModels
{
    public class UpdateDivisionVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public UpdateDivisionVM(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }
    }
}
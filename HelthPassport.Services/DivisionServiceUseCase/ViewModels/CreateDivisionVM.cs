namespace HelthPassport.Services.DivisionServiceUseCase.ViewModels
{
    public class CreateDivisionVM
    {
        public string Name { get; set; }

        public CreateDivisionVM(string name = null)
        {
            Name = name;
        }
    }
}
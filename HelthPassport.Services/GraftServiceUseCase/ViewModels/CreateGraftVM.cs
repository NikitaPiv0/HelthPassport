namespace HelthPassport.Services.GraftServiceUseCase.ViewModels
{
    public class CreateGraftVM
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public CreateGraftVM(
            DateTime date = default,
            string name = null)
        {
            Date = date;
            Name = name;
        }
    }
}
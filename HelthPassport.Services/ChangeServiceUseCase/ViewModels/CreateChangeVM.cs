namespace HelthPassport.Services.ChangeServiceUseCase.ViewModels
{
    public class CreateChangeVM
    {
        public DateTime Date { get; set; }
        public double Growth { get; set; }
        public double Weight { get; set; }

        public CreateChangeVM(
            DateTime date = default,
            double growth = 0,
            double weight = 0)
        {
            Date = date;
            Growth = growth;
            Weight = weight;
        }
    }
}
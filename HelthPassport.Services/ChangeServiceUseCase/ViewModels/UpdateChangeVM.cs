namespace HelthPassport.Services.ChangeServiceUseCase.ViewModels
{
    public class UpdateChangeVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Growth { get; set; }
        public double Weight { get; set; }

        
        public UpdateChangeVM(
            Guid id = default,
            DateTime date = default,
            double growth = 0,
            double weight = 0)
        {
            Id = id;
            Date = date;
            Growth = growth;
            Weight = weight;
        }
    }
}
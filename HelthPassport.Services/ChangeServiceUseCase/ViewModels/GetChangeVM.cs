using HelthPassport.Entities;

namespace HelthPassport.Services.ChangeServiceUseCase.ViewModels
{
    public class GetChangeVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Growth { get; set; }
        public double Weight { get; set; }
        
        public GetChangeVM(
            Guid id = default,
            DateTime date = default,
            double growth = 0.0,
            double weight = 0.0)
        {
            Id = id;
            Date = date;
            Growth = Math.Round(growth, 2);
            Weight = Math.Round(weight, 2);
        }

        public GetChangeVM(Change change)
        {
            Id = change.Id;
            Date = change.Date;
            Growth = Math.Round(change.Growth, 2);
            Weight = Math.Round(change.Weight, 2);
        }
    }
}
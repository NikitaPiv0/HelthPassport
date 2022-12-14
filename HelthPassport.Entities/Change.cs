using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class Change : EntityBase<Guid>
    {
        public DateTime Date { get; set; }
        public double Growth { get; set; }
        public double Weight { get; set; }

        public Change(
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
    }
}
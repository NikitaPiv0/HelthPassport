using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class Femily : EntityBase<Guid>
    {
        public DateTime Start { get; set; }
        public DateTime? End { get; set;  }

        public Femily(
            Guid id = default,
            DateTime start = default,
            DateTime? end = null)
        {
            Id = id;
            Start = start;
            End = end;
        }
    }
}
using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class Graft : EntityBase<Guid>
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public Graft(
            Guid id = default,
            DateTime date = default,
            string name = null)
        {
            Id = id;
            Date = date;
            Name = name;
        }
    }
}
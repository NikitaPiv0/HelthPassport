using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class Division : EntityBase<Guid>
    {
        public string Name { get; set; }

        public Division(
            Guid id = default,
            string name = null)
        {
            Id = id;
            Name = name;
        }
    }
}
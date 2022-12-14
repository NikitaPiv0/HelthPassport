using System.Linq.Expressions;
using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class Disease : EntityBase<Guid>
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public Disease(
            Guid id = default,
            string name = null,
            DateTime start = default,
            DateTime? end = null)
        {
            Id = id;
            Name = name;
            Start = start;
            End = end;
        }
    }
}
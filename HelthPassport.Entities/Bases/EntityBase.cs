using System;

namespace HelthPassport.Entities.Bases
{
    public abstract class EntityBase<TIdentifier>
    {
        public TIdentifier Id { get; set; }
    }
}
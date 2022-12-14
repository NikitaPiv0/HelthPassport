using HelthPassport.Entities.Bases;

namespace HelthPassport.Entities
{
    public class EmployeeMoving : EntityBase<Guid>
    {
        public Guid DivisionId { get; set; }
        public Division Division { get; set; }
        public Guid PositionId { get; set; }
        public EmployeePosition Position { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Payment { get; set; }

        public EmployeeMoving(
            Guid id = default,
            Guid divisionId = default,
            Division division = null,
            Guid positionId = default,
            EmployeePosition position = null,
            DateTime start = default,
            DateTime end = default,
            decimal payment = 0)
        {
            Id = id;
            DivisionId = divisionId;
            Division = division;
            PositionId = positionId;
            Position = position;
            Start = start;
            End = end;
            Payment = payment;
        }
    }
}
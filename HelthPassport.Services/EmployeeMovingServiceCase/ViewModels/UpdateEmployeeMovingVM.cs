namespace HelthPassport.Services.EmployeeMovingServiceCase.ViewModels
{
    public class UpdateEmployeeMovingVM
    {
        public Guid Id { get; set; }
        public Guid DivisionId { get; set; }
        public Guid PositionId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Payment { get; set; }

        public UpdateEmployeeMovingVM(
            Guid id = default,
            Guid divisionId = default,
            Guid positionId = default,
            DateTime start = default,
            DateTime end = default,
            decimal payment = 0)
        {
            Id = id;
            DivisionId = divisionId;
            PositionId = positionId;
            Start = start;
            End = end;
            Payment = payment;
        }
    }
}
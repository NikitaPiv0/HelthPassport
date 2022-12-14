using HelthPassport.Entities;

namespace HelthPassport.Services.EmployeeMovingServiceCase.ViewModels
{
    public class GetEmployeeMovingVM
    {
        public Guid DivisionId { get; set; }
        public string DivisionName { get; set; }
        public Guid PositionId { get; set; }
        public string PositionName { get; set; }
        public string PositionCategoryName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Payment { get; set; }

        public GetEmployeeMovingVM(
            Guid divisionId = default,
            string divisionName = null,
            Guid positionId = default,
            string positionName = null,
            string positionCategoryName = null,
            DateTime start = default,
            DateTime end = default,
            decimal payment = 0)
        {
            DivisionId = divisionId;
            DivisionName = divisionName;
            PositionId = positionId;
            PositionName = positionName;
            PositionCategoryName = positionCategoryName;
            Start = start;
            End = end;
            Payment = payment;
        }

        public GetEmployeeMovingVM(EmployeeMoving employeeMoving)
        {
            DivisionId = employeeMoving.DivisionId;
            DivisionName = employeeMoving.Division.Name;
            PositionId = employeeMoving.PositionId;
            PositionName = employeeMoving.Position.Name;
            PositionCategoryName = employeeMoving.Position.Category.Name;
            Start = employeeMoving.Start;
            End = employeeMoving.End;
            Payment = employeeMoving.Payment;
        }
    }
}
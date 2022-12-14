namespace HelthPassport.Services.FemilyServiceUseCase.ViewModels
{
    public class CreateFemiliyVM
    {
        public DateTime Start { get; set; }
        public DateTime? End { get; set;  }

        public CreateFemiliyVM(
            DateTime start = default,
            DateTime? end = null)
        {
            Start = start;
            End = end;
        }
    }
}
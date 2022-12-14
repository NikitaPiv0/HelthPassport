namespace HelthPassport.Services.FemilyServiceUseCase.ViewModels
{
    public class UpdateFemilyVM
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set;  }

        public UpdateFemilyVM(
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
using HelthPassport.Entities;

namespace HelthPassport.Services.FemilyServiceUseCase.ViewModels
{
    public class GetFemilyVM
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set;  }

        public GetFemilyVM(
            Guid id = default,
            DateTime start = default,
            DateTime? end = null)
        {
            Id = id;
            Start = start;
            End = end;
        }
        
        public GetFemilyVM(Femily femily)
        {
            Id = femily.Id;
            Start = femily.Start;
            End = femily.End;
        }
    }
}
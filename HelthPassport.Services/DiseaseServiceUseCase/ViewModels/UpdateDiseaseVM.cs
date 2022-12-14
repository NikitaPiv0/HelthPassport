namespace HelthPassport.Services.DiseaseServiceUseCase.ViewModels
{
    public class UpdateDiseaseVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public UpdateDiseaseVM(
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
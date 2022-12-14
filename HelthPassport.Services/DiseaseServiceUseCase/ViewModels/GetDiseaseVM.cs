using HelthPassport.Entities;

namespace HelthPassport.Services.DiseaseServiceUseCase.ViewModels
{
    public class GetDiseaseVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public GetDiseaseVM(
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
        
        public GetDiseaseVM(Disease disease)
        {
            Id = disease.Id;
            Name = disease.Name;
            Start = disease.Start;
            End = disease.End;
        }
    }
}
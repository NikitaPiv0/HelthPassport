namespace HelthPassport.Services.DiseaseServiceUseCase.ViewModels
{
    public class CreateDiseaseVM
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }

        public CreateDiseaseVM(
            string name = null,
            DateTime start = default)
        {
            Name = name;
            Start = start;
        }
    }
}
using HelthPassport.Entities.Enums;

namespace HelthPassport.Services.EducationServiceUseCase.ViewModels
{
    public class CreateEducationVM
    {
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Document { get; set; }
        public EducationEnum Level { get; set; }

        public CreateEducationVM(
            DateTime date = default,
            string company = null,
            string document = null,
            EducationEnum level = default)
        {
            Date = date;
            Company = company;
            Document = document;
            Level = level;
        }
    }
}
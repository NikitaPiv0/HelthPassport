using HelthPassport.Entities.Enums;

namespace HelthPassport.Services.EducationServiceUseCase.ViewModels
{
    public class UpdateEducationVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Document { get; set; }
        public EducationEnum Level { get; set; }

        public UpdateEducationVM(
            Guid id = default,
            DateTime date = default,
            string company = null,
            string document = null,
            EducationEnum level = default)
        {
            Id = id;
            Date = date;
            Company = company;
            Document = document;
            Level = level;
        }
    }
}
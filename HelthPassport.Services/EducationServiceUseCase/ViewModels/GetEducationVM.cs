using HelthPassport.Entities;
using HelthPassport.Entities.Enums;

namespace HelthPassport.Services.EducationServiceUseCase.ViewModels
{
    public class GetEducationVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Document { get; set; }
        public EducationEnum Level { get; set; }

        public GetEducationVM(
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

        public GetEducationVM(Education education)
        {
            Id = education.Id;
            Date = education.Date;
            Company = education.Company;
            Document = education.Document;
            Level = education.Level;
        }
    }
}
using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.EducationServiceUseCase.ViewModels;

namespace HelthPassport.Services.EducationServiceUseCase
{
    public class EducationService : ServiceBase<Education, GetEducationVM>,
        ICrudService<GetEducationVM, CreateEducationVM, UpdateEducationVM>
    {
        private readonly Func<Education, GetEducationVM> mapper
            = change => new GetEducationVM(change);

        public IEnumerable<GetEducationVM> GetAll() => base.GetAll(mapper);
        public GetEducationVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateEducationVM entity)
            => base.Create(new Education(
                id: Guid.NewGuid(),
                date: entity.Date,
                company: entity.Company,
                document: entity.Document,
                level: entity.Level));

        public void Update(UpdateEducationVM entity)
            => base.Update(entity.Id, education => 
                {
                    education.Date = entity.Date;
                    education.Company = entity.Company;
                    education.Document = entity.Document;
                    education.Level = entity.Level;
                });
    }
}
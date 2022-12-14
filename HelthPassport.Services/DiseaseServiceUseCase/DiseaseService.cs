using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.DiseaseServiceUseCase.ViewModels;

namespace HelthPassport.Services.DiseaseServiceUseCase
{
    public class DiseaseService : ServiceBase<Disease, GetDiseaseVM>,
        ICrudService<GetDiseaseVM, CreateDiseaseVM, UpdateDiseaseVM>
    {
        private readonly Func<Disease, GetDiseaseVM> mapper
            = change => new GetDiseaseVM(change);

        public IEnumerable<GetDiseaseVM> GetAll() => base.GetAll(mapper);
        public GetDiseaseVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateDiseaseVM entity)
            => base.Create(new Disease(
                id: Guid.NewGuid(),
                name: entity.Name,
                start: entity.Start));

        public void Update(UpdateDiseaseVM entity)
            => base.Update(entity.Id, disease => 
                {
                    disease.Name = entity.Name;
                    disease.Start = entity.Start;
                    disease.End = disease.End;
                });
    }
}
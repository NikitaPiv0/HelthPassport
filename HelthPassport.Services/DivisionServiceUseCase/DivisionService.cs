using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.DivisionServiceUseCase.ViewModels;

namespace HelthPassport.Services.DivisionServiceUseCase
{
    public class DivisionService : ServiceBase<Division, GetDivisionVM>,
        ICrudService<GetDivisionVM, CreateDivisionVM, UpdateDivisionVM>
    {
        private readonly Func<Division, GetDivisionVM> mapper
            = change => new GetDivisionVM(change);

        public IEnumerable<GetDivisionVM> GetAll() => base.GetAll(mapper);
        public GetDivisionVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateDivisionVM entity)
            => base.Create(new Division(
                id: Guid.NewGuid(),
                name: entity.Name));

        public void Update(UpdateDivisionVM entity)
            => base.Update(entity.Id, disease => 
                {
                    disease.Name = entity.Name;
                });
    }
}
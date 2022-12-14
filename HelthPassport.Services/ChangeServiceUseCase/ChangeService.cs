using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.ChangeServiceUseCase.ViewModels;

namespace HelthPassport.Services.ChangeServiceUseCase
{
    public class ChangeService : ServiceBase<Change, GetChangeVM>,
        ICrudService<GetChangeVM, CreateChangeVM, UpdateChangeVM>
    {
        private readonly Func<Change, GetChangeVM> mapper
            = change => new GetChangeVM(change);

        public IEnumerable<GetChangeVM> GetAll() => base.GetAll(mapper);
        public GetChangeVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateChangeVM entity)
            => base.Create(new Change(
                id: Guid.NewGuid(),
                date: entity.Date,
                growth: entity.Growth,
                weight: entity.Weight));

        public void Update(UpdateChangeVM entity)
            => base.Update(entity.Id, change => 
                {
                    change.Date = entity.Date;
                    change.Growth = entity.Growth;
                    change.Weight = change.Weight;   
                });
    }
}
using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.GraftServiceUseCase.ViewModels;

namespace HelthPassport.Services.GraftServiceUseCase
{
    public class GraftService : ServiceBase<Graft, GetGraftVM>,
        ICrudService<GetGraftVM, CreateGraftVM, UpdateGraftVM>
    {
        private readonly Func<Graft, GetGraftVM> mapper
            = change => new GetGraftVM(change);

        public IEnumerable<GetGraftVM> GetAll() => base.GetAll(mapper);
        public GetGraftVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateGraftVM entity)
            => base.Create(new Graft(
                id: Guid.NewGuid(),
                date: entity.Date,
                name: entity.Name));

        public void Update(UpdateGraftVM entity)
            => base.Update(entity.Id, graft => 
                {
                    graft.Date = entity.Date;
                    graft.Name = entity.Name;
                });
    }
}
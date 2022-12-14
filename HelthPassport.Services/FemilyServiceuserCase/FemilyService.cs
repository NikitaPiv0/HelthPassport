using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.FemilyServiceUseCase.ViewModels;

namespace HelthPassport.Services.FemilyServiceUseCase
{
    public class FemilyService : ServiceBase<Femily, GetFemilyVM>,
        ICrudService<GetFemilyVM, CreateFemiliyVM, UpdateFemilyVM>
    {
        private readonly Func<Femily, GetFemilyVM> mapper
            = femily => new GetFemilyVM(femily);

        public IEnumerable<GetFemilyVM> GetAll() => base.GetAll(mapper);
        public GetFemilyVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateFemiliyVM entity)
            => base.Create(new Femily(
                id: Guid.NewGuid(),
                start: entity.Start,
                end: entity.End));

        public void Update(UpdateFemilyVM entity)
            => base.Update(entity.Id, femily =>
                {
                    femily.Start = entity.Start;
                    femily.End = entity.End;
                });
    }
}
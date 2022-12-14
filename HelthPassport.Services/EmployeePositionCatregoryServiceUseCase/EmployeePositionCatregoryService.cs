using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.EmployeePositionCatregoryServiceUseCase.ViewModels;

namespace HelthPassport.Services.EmployeePositionCatregoryServiceUseCase
{
    public class EmployeePositionCatregoryService : ServiceBase<EmployeePositionCatregory, GetEmployeePositionCatregoryVM>,
        ICrudService<GetEmployeePositionCatregoryVM, CreateEmployeePositionCatregoryVM, UpdateEmployeePositionCatregoryVM>
    {
        private readonly Func<EmployeePositionCatregory, GetEmployeePositionCatregoryVM> mapper
            = change => new GetEmployeePositionCatregoryVM(change);

        public IEnumerable<GetEmployeePositionCatregoryVM> GetAll() => base.GetAll(mapper);
        public GetEmployeePositionCatregoryVM Get(Guid id) => base.Get(id, mapper);
        public void Create(CreateEmployeePositionCatregoryVM entity)
            => base.Create(new EmployeePositionCatregory(
                id: Guid.NewGuid(),
                name: entity.Name));

        public void Update(UpdateEmployeePositionCatregoryVM entity)
            => base.Update(entity.Id, catregory => 
                {
                    catregory.Name = entity.Name;
                });
    }
}
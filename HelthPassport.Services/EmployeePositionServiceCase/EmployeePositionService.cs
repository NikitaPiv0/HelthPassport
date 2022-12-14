using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.EF;
using HelthPassport.Services.EmployeePositionServiceCase.ViewModels;
using HelthPassport.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace HelthPassport.Services.EmployeePositionServiceCase
{
    public class EmployeePositionService : ServiceBase<EmployeePosition, GetEmployeePositionVM>,
        ICrudService<GetEmployeePositionVM, CreateEmployeePositionVM, UpdateEmployeePositionVM>
    {
        private readonly Func<EmployeePosition, GetEmployeePositionVM> mapper
            = change => new GetEmployeePositionVM(change);

        public IEnumerable<GetEmployeePositionVM> GetAll()
        {
            using (AppDbContext db = new  AppDbContext())
            {
                return db.Positions
                    .Include(position => position.Category)
                    .Select(position => new GetEmployeePositionVM(position))
                    .ToList();
            }
        }

        public GetEmployeePositionVM Get(Guid id)
        {
            using (AppDbContext db = new  AppDbContext())
            {
                EmployeePosition position = db.Positions
                    .Include(position => position.Category)
                    .SingleOrDefault(position => position.Id == id);
                
                if (position is null)
                {
                    throw new EntityNotFoundException();
                }

                return new GetEmployeePositionVM(position);
            }
        }

        public void Create(CreateEmployeePositionVM entity)
            => base.Create(new EmployeePosition(
                id: Guid.NewGuid(),
                name: entity.Name,
                categoryId: entity.CategoryId));

        public void Update(UpdateEmployeePositionVM entity)
            => base.Update(entity.Id, catregory => 
                {
                    catregory.Name = entity.Name;
                    catregory.CategoryId = entity.CategoryId;
                });
    }
}
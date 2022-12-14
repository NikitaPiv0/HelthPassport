using HelthPassport.DataBase.Interfaces;
using HelthPassport.Entities;
using HelthPassport.Services.EF;
using HelthPassport.Services.EmployeeMovingServiceCase.ViewModels;
using HelthPassport.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace HelthPassport.Services.EmployeeMovingServiceCase
{
    public class EmployeeMovingService : ServiceBase<EmployeeMoving, GetEmployeeMovingVM>,
        ICrudService<GetEmployeeMovingVM, CreateEmployeeMovingVM, UpdateEmployeeMovingVM>
    {
        private readonly Func<EmployeeMoving, GetEmployeeMovingVM> mapper
            = change => new GetEmployeeMovingVM(change);

        public IEnumerable<GetEmployeeMovingVM> GetAll()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Movings
                    .Include(moving => moving.Division)
                    .Include(moving => moving.Position)
                        .ThenInclude(position => position.Category)
                    .Select(moving => new GetEmployeeMovingVM(moving))
                    .ToList();
            }
        }

        public GetEmployeeMovingVM Get(Guid id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                EmployeeMoving moving = db.Movings
                    .Include(moving => moving.Division)
                    .Include(moving => moving.Position)
                        .ThenInclude(position => position.Category)
                    .SingleOrDefault(moving => moving.Id == id);
                
                if (moving is null)
                {
                    throw new EntityNotFoundException();
                }

                return new GetEmployeeMovingVM(moving);
            }
        }

        public void Create(CreateEmployeeMovingVM entity)
            => base.Create(new EmployeeMoving(
                id: Guid.NewGuid(),
                divisionId: entity.DivisionId,
                positionId: entity.PositionId,
                start: entity.Start,
                end: entity.End,
                payment: entity.Payment));

        public void Update(UpdateEmployeeMovingVM entity)
            => base.Update(entity.Id, moving => 
                {
                    moving.DivisionId = entity.DivisionId;
                    moving.PositionId = entity.PositionId;
                    moving.Start = entity.Start;
                    moving.End = entity.End;
                    moving.Payment = entity.Payment;
                });
    }
}
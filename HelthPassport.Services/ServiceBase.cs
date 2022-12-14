using HelthPassport.Services.EF;
using HelthPassport.Services.Exceptions;

namespace HelthPassport.Services
{
    public abstract class ServiceBase<TEntity, TGetEntityVM>
        where TEntity : class
        where TGetEntityVM : class
    {
        protected virtual TEntity GetById(AppDbContext db, Guid id)
        {
            TEntity entity = db.Set<TEntity>().Find(new object[] { id });

            if (entity is null)
            {
                throw new EntityNotFoundException();
            }

            return entity;
        }

        protected virtual IEnumerable<TGetEntityVM> GetAll(Func<TEntity, TGetEntityVM> mapper)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Set<TEntity>().Select(mapper).ToList();
            }
        }

        protected virtual TGetEntityVM Get(Guid id, Func<TEntity, TGetEntityVM> mapper)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return mapper(GetById(db, id));
            }
        }

        protected virtual void Create(TEntity entity)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
            }
        }

        protected virtual void Update(Guid id, Action<TEntity> updater)
        {
            using (AppDbContext db = new AppDbContext())
            {
                updater(GetById(db, id));
                db.SaveChanges();
            }
        }

        public virtual void Delete(Guid id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Set<TEntity>().Remove(GetById(db, id));
                db.SaveChanges();
            }
        }
    }
}
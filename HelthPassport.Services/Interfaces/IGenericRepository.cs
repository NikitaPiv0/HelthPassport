using System.Collections.Generic;

namespace HelthPassport.DataBase.Interfaces
{
    public interface ICrudService <TGetEntityVM, TCreateEntityVM, TUpdateEntityVM>
    {
        IEnumerable<TGetEntityVM> GetAll();
        TGetEntityVM Get(Guid id);
        void Create(TCreateEntityVM entity);
        void Update(TUpdateEntityVM entity);
        void Delete(Guid id);
    }
}
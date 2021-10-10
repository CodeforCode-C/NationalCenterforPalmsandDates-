using System.Collections.Generic;

namespace NationalCenterforPalmsandDates.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetbyId(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}

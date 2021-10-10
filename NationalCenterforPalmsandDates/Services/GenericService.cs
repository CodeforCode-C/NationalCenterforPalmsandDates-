using Microsoft.EntityFrameworkCore;
using NationalCenterforPalmsandDates.Data;
using NationalCenterforPalmsandDates.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NationalCenterforPalmsandDates.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> table = null;

        public GenericService(ApplicationDbContext context)
        {
            _context = context;
            table = _context.Set<T>();

        }
        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Delete(object id)
        {
            T exist = GetbyId(id);
            table.Remove(exist);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetbyId(object id)
        {
            return table.Find(id);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

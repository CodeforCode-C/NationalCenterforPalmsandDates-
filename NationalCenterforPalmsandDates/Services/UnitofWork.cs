using NationalCenterforPalmsandDates.Data;
using NationalCenterforPalmsandDates.Interfaces;

namespace NationalCenterforPalmsandDates.Services
{
    public class UnitofWork<T> : IUnitofWork<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private IGenericService<T> _entity;

        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public IGenericService<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericService<T>(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

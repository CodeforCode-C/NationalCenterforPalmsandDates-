namespace NationalCenterforPalmsandDates.Interfaces
{
    public interface IUnitofWork<T> where T : class
    {
        IGenericService<T> Entity { get;}
        void Save();
    }
}

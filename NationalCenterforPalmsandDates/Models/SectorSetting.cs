namespace NationalCenterforPalmsandDates.Models
{
    public class SectorSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpecifiedQuantity { get; set; }
        public string CityofSupply { get; set; }
        public bool IsCanceled { get; set; }
    }
}

using System;

namespace NationalCenterforPalmsandDates.Models
{
    public class SeasonSetting
    {
        public int Id { get; set; }
        public DateTime Startat { get; set; }
        public DateTime Endat { get; set; }
        public bool IsCanceled { get; set; }
    }
}

using System;

namespace NationalCenterforPalmsandDates.ViewModels
{
    public class SeasonSettingViewModel
    {
        public int Id { get; set; }
        public DateTime Startat { get; set; }
        public DateTime Endat { get; set; }
        public bool IsCanceled { get; set; }
    }


}

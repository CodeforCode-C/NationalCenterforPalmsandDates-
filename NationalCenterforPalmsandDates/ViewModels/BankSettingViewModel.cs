using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalCenterforPalmsandDates.ViewModels
{
    public class BankSettingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BankCode { get; set; }
        public bool IsCanceled { get; set; }
    }

}

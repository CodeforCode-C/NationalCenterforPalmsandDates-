using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using System.Linq;

namespace NationalCenterforPalmsandDates.Helper
{
    public class QuantatiesSpecification
    {
        private readonly IUnitofWork<FarmerSetting> _unitofWork;

        public QuantatiesSpecification(IUnitofWork<FarmerSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public void QuantatiesSpecificationFun()
        {
           
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Controllers
{
    public class SectorSettingsController : Controller
    {
        private readonly IUnitofWork<SectorSetting> _unitofWork;

        public SectorSettingsController(IUnitofWork<SectorSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var sectorSettings = _unitofWork.Entity.GetAll();
            return View(sectorSettings);
        }

        public IActionResult GetbyId(int id)
        {
            var sector = _unitofWork.Entity.GetbyId(id);
            return View(sector);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SectorSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SectorSetting sectorSetting = new SectorSetting
                {
                    Name = viewModel.Name,
                    CityofSupply = viewModel.CityofSupply,
                    SpecifiedQuantity = viewModel.SpecifiedQuantity
                };
                _unitofWork.Entity.Add(sectorSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sectorSettinginDB = _unitofWork.Entity.GetbyId(id);
            SectorSettingViewModel viewModel = new SectorSettingViewModel
            {
                Name = sectorSettinginDB.Name,
                CityofSupply = sectorSettinginDB.CityofSupply,
                SpecifiedQuantity = sectorSettinginDB.SpecifiedQuantity
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, SectorSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SectorSetting sectorSetting = new SectorSetting
                {
                    Name = viewModel.Name,
                    CityofSupply = viewModel.CityofSupply,
                    SpecifiedQuantity = viewModel.SpecifiedQuantity
                };
                _unitofWork.Entity.Update(sectorSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}

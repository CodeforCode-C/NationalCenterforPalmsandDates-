using Microsoft.AspNetCore.Mvc;
using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Controllers
{
    public class SectoreQuantatiesSettingsController : Controller
    {
        private readonly IUnitofWork<SectoreQuantatiesSetting> _unitofWork;

        public SectoreQuantatiesSettingsController(IUnitofWork<SectoreQuantatiesSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var SectoreQuantatiesSettings = _unitofWork.Entity.GetAll();

            return View(SectoreQuantatiesSettings);
        }

        public IActionResult GetbyId(int id)
        {
            var SectoreQuantatiesSetting = _unitofWork.Entity.GetbyId(id);
            return View(SectoreQuantatiesSetting);
        }

        [HttpGet]
        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creat(SectoreQuantatiesSettingViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                SectoreQuantatiesSetting sectoreQuantatiesSetting = new SectoreQuantatiesSetting()
                {
                    Name = viewModel.Name,
                    PerDayAllowedTones = viewModel.PerDayAllowedTones
                };
                _unitofWork.Entity.Add(sectoreQuantatiesSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            SectoreQuantatiesSetting sectoreQuantatiesSettinginDB = _unitofWork.Entity.GetbyId(id);
            SectoreQuantatiesSettingViewModel viewModel = new SectoreQuantatiesSettingViewModel
            {
                Name = sectoreQuantatiesSettinginDB.Name,
                PerDayAllowedTones = sectoreQuantatiesSettinginDB.PerDayAllowedTones
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, SectoreQuantatiesSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SectoreQuantatiesSetting sectoreQuantatiesSetting = new SectoreQuantatiesSetting
                {
                    Name = viewModel.Name,
                    PerDayAllowedTones = viewModel.PerDayAllowedTones
                };
                _unitofWork.Entity.Update(sectoreQuantatiesSetting);
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

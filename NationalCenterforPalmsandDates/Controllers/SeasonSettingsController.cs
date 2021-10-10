using Microsoft.AspNetCore.Mvc;
using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Controllers
{
    public class SeasonSettingsController : Controller
    {
        private readonly IUnitofWork<SeasonSetting> _unitofWork;

        public SeasonSettingsController(IUnitofWork<SeasonSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IActionResult Index()
        {
            var seasons = _unitofWork.Entity.GetAll();
            return View(seasons);
        }

        public IActionResult GetbyId(int id)
        {
            var season = _unitofWork.Entity.GetbyId(id);
            return View(season);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SeasonSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SeasonSetting seasonSetting = new SeasonSetting
                {
                    Startat = viewModel.Startat,
                    Endat = viewModel.Endat
                };
                _unitofWork.Entity.Add(seasonSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sessioninDB = _unitofWork.Entity.GetbyId(id);
            SeasonSettingViewModel viewModel = new SeasonSettingViewModel
            {
                Startat = sessioninDB.Startat,
                Endat = sessioninDB.Endat,

            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, SeasonSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                SeasonSetting seasonSetting = new SeasonSetting
                {
                    Startat = viewModel.Startat,
                    Endat = viewModel.Endat
                };
                _unitofWork.Entity.Update(seasonSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Controllers
{
    public class DatesSettingsController : Controller
    {
        private readonly IUnitofWork<DatesSetting> _unitofWork;

        public DatesSettingsController(IUnitofWork<DatesSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var dates = _unitofWork.Entity.GetAll();
            return View(dates);
        }

        public IActionResult GetbyId(int id)
        {
            var date = _unitofWork.Entity.GetbyId(id);
            return View(date);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DatesSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var dateSetting = new DatesSetting
                {
                    Name = viewModel.Name
                };
                _unitofWork.Entity.Add(dateSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var datesinDB = _unitofWork.Entity.GetbyId(id);
            DatesSettingViewModel viewModel = new DatesSettingViewModel
            {
                Id = datesinDB.Id,
                Name = datesinDB.Name
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, DatesSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                DatesSetting datesSettinginDB = new DatesSetting()
                {
                    Id = viewModel.Id,
                    Name = viewModel.Name
                };
                _unitofWork.Entity.Update(datesSettinginDB);
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

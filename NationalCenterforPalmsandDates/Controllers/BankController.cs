using Microsoft.AspNetCore.Mvc;
using NationalCenterforPalmsandDates.Interfaces;
using NationalCenterforPalmsandDates.Models;
using NationalCenterforPalmsandDates.ViewModels;

namespace NationalCenterforPalmsandDates.Controllers
{
    public class BankController : Controller
    {
        private readonly IUnitofWork<BankSetting> _unitofWork;

        public BankController(IUnitofWork<BankSetting> unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var Banks = _unitofWork.Entity.GetAll();
            return View(Banks);
        }

        public IActionResult GetbyId(int id)
        {
            var bank = _unitofWork.Entity.GetbyId(id);
            return View(bank);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(BankSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var bankSetting = new BankSetting
                {
                    BankCode = viewModel.BankCode,
                    Name = viewModel.Name
                };
                _unitofWork.Entity.Add(bankSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bankinDb = _unitofWork.Entity.GetbyId(id);
            BankSettingViewModel viewModel = new BankSettingViewModel
            {
                Id = bankinDb.Id,
                Name = bankinDb.Name,
                BankCode = bankinDb.BankCode
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, BankSettingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                BankSetting bankSetting = new BankSetting
                {
                    Id = viewModel.Id,
                    BankCode = viewModel.BankCode,
                    Name = viewModel.Name
                };
                _unitofWork.Entity.Update(bankSetting);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }
        // To DO
        public IActionResult Delete(int id)
        {
            var bankinDB = _unitofWork.Entity.GetbyId(id);
            if (bankinDB != null)
            {
                bankinDB.IsCanceled = true;
                RedirectToAction(nameof(Index));
            }
            return NotFound();
        }



    }
}

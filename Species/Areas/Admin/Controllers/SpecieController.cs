using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Species.Data.Models;
using Species.Data.Repository.IRepository;

namespace Species.Areas.Admin.Controllers
{
      [Area("Admin")]
        public class SpecieController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public SpecieController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Upsert(int? id)
            {
                Specie specie = new Specie();
                if (id == null)
                {
                    //this is for create
                    return View(specie);
                }
                //this is for edit
                specie = _unitOfWork.Specie.Get(id.GetValueOrDefault());
                if (specie == null)
                {
                    return NotFound();
                }
                return View(specie);

            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(Specie specie)
            {
                if (ModelState.IsValid)
                {
                    if (specie.Id == 0)
                    {
                        _unitOfWork.Specie.Add(specie);

                    }
                    else
                    {
                        _unitOfWork.Specie.Update(specie);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(specie);
            }


            #region API CALLS

            [HttpGet]
            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Specie.GetAll();
                return Json(new { data = allObj });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.Specie.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting" });
                }
                _unitOfWork.Specie.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete Successful" });

            }

            #endregion
        }
    }

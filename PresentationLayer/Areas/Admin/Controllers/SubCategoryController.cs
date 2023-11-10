using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryManager _subCategoryManager;

        public SubCategoryController(ISubCategoryManager subCategoryManager)
        {
            _subCategoryManager = subCategoryManager;
        }

        // GET: SubCategoryController
        public ActionResult Index()
        {
            var listele = _subCategoryManager.GetSubCategoryListManager();
            return View(listele);
        }

        // GET: SubCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubCategoory subCategoory)
        {
            try
            {
                _subCategoryManager.Add(subCategoory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir = _subCategoryManager.GetByID(id);
            return View(datagetir);
        }

        // POST: SubCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,SubCategoory subCategoory)
        {
            try
            {
                _subCategoryManager.Update(subCategoory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _subCategoryManager.GetByID(id);
            return View(datagetir);
        }

        // POST: SubCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SubCategoory subCategoory)
        {
            try
            {
                _subCategoryManager.Remove(subCategoory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

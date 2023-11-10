using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TopCategoryController : Controller
    {
        private readonly ITopCategoryManager _topCategoryManager;

        public TopCategoryController(ITopCategoryManager topCategoryManager)
        {
            _topCategoryManager = topCategoryManager;
        }

        public ActionResult Index()
        {
            var listele = _topCategoryManager.GetList();
            return View(listele);
        }

        // GET: TopCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TopCategory topCategory)
        {
            try
            {
                   _topCategoryManager.Add(topCategory);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir=_topCategoryManager.GetByID(id);
            return View(datagetir);
        }

        // POST: TopCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TopCategory topCategory)
        {
            try
            {
                _topCategoryManager.Update(topCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _topCategoryManager.GetByID(id);
            return View(datagetir);
        }

        // POST: TopCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TopCategory topCategory)
        {
            try
            {
                _topCategoryManager.Remove(topCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

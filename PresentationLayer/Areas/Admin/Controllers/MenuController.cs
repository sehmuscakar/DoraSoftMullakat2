using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class MenuController : Controller
    {
        private readonly IMenuManager _menuManager;

        public MenuController(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        // GET: MenuController
        public ActionResult Index()
        {
            var listele = _menuManager.GetList();
            return View(listele);
        }

  

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu menu)
        {
            try
            {
                _menuManager.Add(menu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir = _menuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Menu menu)
        {
            try
            {
                _menuManager.Update(menu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _menuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Menu menu)
        {
            try
            {
                _menuManager.Remove(menu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

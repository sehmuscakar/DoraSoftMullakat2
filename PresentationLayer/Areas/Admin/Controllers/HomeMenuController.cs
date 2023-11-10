using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class HomeMenuController : Controller
    {
        private readonly IHomeMenuManager _homeMenuManager;

        public HomeMenuController(IHomeMenuManager homeMenuManager)
        {
            _homeMenuManager = homeMenuManager;
        }

        // GET: HomeMenuController
        public ActionResult Index()
        {
            var listele=_homeMenuManager.GetList();
            return View(listele);
        }



        // GET: HomeMenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HomeMenu homeMenu)
        {
            try
            {
                _homeMenuManager.Add(homeMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir=_homeMenuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: HomeMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HomeMenu homeMenu)
        {
            try
            {
                _homeMenuManager.Update(homeMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeMenuController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _homeMenuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: HomeMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, HomeMenu homeMenu)
        {
            try
            {
                _homeMenuManager.Remove(homeMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

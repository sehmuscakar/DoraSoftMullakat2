using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class SubMenuController : Controller
    {
        private readonly ISubMenuManager _subMenuManager;

        public SubMenuController(ISubMenuManager subMenuManager)
        {
            _subMenuManager = subMenuManager;
        }

        // GET: SubMenuController
        public ActionResult Index()
        {
            var listele = _subMenuManager.GetSubMenuListManager();
            return View(listele);
        }


        // GET: SubMenuController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: SubMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubMenu subMenu)
        {
            try
            {
                _subMenuManager.Add(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var datagetir=_subMenuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: SubMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SubMenu subMenu)
        {
            try
            {
                _subMenuManager.Update(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubMenuController/Delete/5
        public ActionResult Delete(int id)
        {
            var datagetir = _subMenuManager.GetByID(id);
            return View(datagetir);
        }

        // POST: SubMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,SubMenu subMenu)
        {
            try
            {
                _subMenuManager.Remove(subMenu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

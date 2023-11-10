using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class HomeCategoryController : Controller
    {
        private readonly ICategoryManager _categoryManager;
        private readonly ICategoryDal _categoryDal;
        private readonly ISubCategoryManager _subCategoryManager;

        public HomeCategoryController(ICategoryManager categoryManager, ICategoryDal categoryDal, ISubCategoryManager subCategoryManager = null)
        {
            _categoryManager = categoryManager;
            _categoryDal = categoryDal;
            _subCategoryManager = subCategoryManager;
        }

        [HttpGet]
        public ActionResult Index(string Name, decimal? Price, string isActive)
        {
            var listele = _categoryManager.GetCategoryByFilterManager(Name, Price, isActive);
            ViewBag.Name = Name;
            ViewBag.Price = Price;
            ViewBag.IsActive = isActive == "on" ? true : false;
            return View(listele);
        }

        public ActionResult Filter()
        {
            return View();
        }

        public ActionResult SubCategory(int id)
        {
           var datagetir= _subCategoryManager.GetSubCategoryGetByIdManager(id);
            return View(datagetir);
        }

    }
}

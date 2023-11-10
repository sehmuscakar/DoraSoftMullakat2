using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryListViewComponent(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _categoryManager.GetcCategoryListManager();
            return View(listele);
        }

    }
}

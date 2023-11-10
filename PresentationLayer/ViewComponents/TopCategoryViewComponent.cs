using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class TopCategoryViewComponent:ViewComponent
    {
        private readonly ITopCategoryManager _topCategoryManager;

        public TopCategoryViewComponent(ITopCategoryManager topCategoryManager)
        {
            _topCategoryManager = topCategoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _topCategoryManager.GetList();
            return View(listele);
        }
    }
}

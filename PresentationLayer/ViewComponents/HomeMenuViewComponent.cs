using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class HomeMenuViewComponent:ViewComponent
    {

        private readonly IHomeMenuManager _homeMenuManager;

        public HomeMenuViewComponent(IHomeMenuManager homeMenuManager)
        {
            _homeMenuManager = homeMenuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _homeMenuManager.GetList();
            return View(listele);
        }
    }
}

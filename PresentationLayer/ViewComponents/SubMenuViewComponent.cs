using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class SubMenuViewComponent:ViewComponent
    {
        private readonly ISubMenuManager subMenuManager;
        private readonly IMenuManager _menuManager;
        public SubMenuViewComponent(ISubMenuManager subMenuManager, IMenuManager menuManager)
        {
            this.subMenuManager = subMenuManager;
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = subMenuManager.GetSubMenuListManager();
            return View(listele);
        }

        public async Task<IViewComponentResult> InvokeAsync2()
        {
            var listele = _menuManager.GetList();
            return View(listele);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.AdminComponents;

public class _AdminSidebarPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

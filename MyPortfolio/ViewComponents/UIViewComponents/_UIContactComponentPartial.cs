using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIContactComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

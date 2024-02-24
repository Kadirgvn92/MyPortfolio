using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIInfoComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

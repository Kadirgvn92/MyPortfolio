using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.AdminComponents;

public class _AdminHeaderPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.AdminComponents;

public class _AdminNavbarPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.AdminComponents;

public class _AdminFooterPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}

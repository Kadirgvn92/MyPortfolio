using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.AdminComponents;

public class _AdminScriptPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();  
    }
}

using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIServiceComponentPartial:ViewComponent
{
    private readonly DbMyPortfolioContext _context;

    public _UIServiceComponentPartial(DbMyPortfolioContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.TblServices.ToList();
        return View(values);
    }
}

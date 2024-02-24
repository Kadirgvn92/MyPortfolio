using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.ComponentModel;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIFeatureComponentPartial : ViewComponent
{
    private readonly DbMyPortfolioContext _context;

    public _UIFeatureComponentPartial(DbMyPortfolioContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.TblFeatures.ToList();
        return View(values);
    }
}

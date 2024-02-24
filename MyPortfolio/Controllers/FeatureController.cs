using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class FeatureController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public FeatureController(DbMyPortfolioContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var values = _context.TblFeatures.ToList();
        return View(values);
    }
}

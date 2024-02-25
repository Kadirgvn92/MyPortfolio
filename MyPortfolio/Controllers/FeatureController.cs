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
    [HttpGet]
    public IActionResult UpdateFeature(int id)
    {
        var values = _context.TblFeatures.FirstOrDefault(x => x.FeatureId == id);
        return View(values);
    }
    [HttpPost]
    public IActionResult UpdateFeature(TblFeature model)
    {
        var values = _context.TblFeatures.FirstOrDefault(x => x.FeatureId == model.FeatureId);

        if (values != null)
        {
            values.Header = model.Header;
            values.Title = model.Title;
            values.NameSurname = model.NameSurname;

            // Değişiklikleri kaydedin
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}

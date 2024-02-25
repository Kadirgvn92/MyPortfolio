using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class AboutController : Controller
{
    private readonly DbMyPortfolioContext _dbMyPortfolioContext;

    public AboutController(DbMyPortfolioContext dbMyPortfolioContext)
    {
        _dbMyPortfolioContext = dbMyPortfolioContext;
    }

    public IActionResult Index()
    {
        var values = _dbMyPortfolioContext.TblAbouts.ToList();
        return View(values);
    }
    [HttpGet]
    public IActionResult UpdateAbout(int id)
    {
        var values = _dbMyPortfolioContext.TblAbouts.FirstOrDefault(x => x.AboutId == id);
        return View(values);
    }
    [HttpPost]
    public IActionResult UpdateAbout(TblAbout model)
    {
        var values = _dbMyPortfolioContext.TblAbouts.FirstOrDefault(x => x.AboutId == model.AboutId);

        if (values != null)
        {
            values.Description = model.Description;
            values.Title = model.Title;
            values.Header = model.Header;
            values.ImageUrl = model.ImageUrl;

            // Değişiklikleri kaydedin
            _dbMyPortfolioContext.SaveChanges();
        }
        return RedirectToAction("Index");
    }

}

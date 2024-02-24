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
}

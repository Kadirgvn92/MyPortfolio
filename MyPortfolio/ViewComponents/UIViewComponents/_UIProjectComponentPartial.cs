using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIProjectComponentPartial : ViewComponent
{
    private readonly DbMyPortfolioContext _dbMyPortfolioContext;

    public _UIProjectComponentPartial(DbMyPortfolioContext dbMyPortfolioContext)
    {
        _dbMyPortfolioContext = dbMyPortfolioContext;
    }

    public IViewComponentResult Invoke()
    {
        var values = _dbMyPortfolioContext.TblProjects.ToList();
        return View(values);
    }
}

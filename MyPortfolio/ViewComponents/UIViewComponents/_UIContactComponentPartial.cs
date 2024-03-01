using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UIContactComponentPartial : ViewComponent
{
    private readonly DbMyPortfolioContext _dbMyPortfolioContext;

    public _UIContactComponentPartial(DbMyPortfolioContext dbMyPortfolioContext)
    {
        _dbMyPortfolioContext = dbMyPortfolioContext;
    }
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

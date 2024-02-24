using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents.UIViewComponents;

public class _UITestimonialComponentPartial : ViewComponent
{
    private readonly DbMyPortfolioContext _context;

    public _UITestimonialComponentPartial(DbMyPortfolioContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.TblTestimonials.ToList();
        return View(values);
    }
}

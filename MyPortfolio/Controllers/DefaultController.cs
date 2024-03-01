using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class DefaultController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public DefaultController(DbMyPortfolioContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(TblContact model)
    {
        _context.TblContacts.Add(new TblContact
        {
            Email = model.Email,
            IsRead = false,
            Message = model.Message,
            MessageCategory = 1,
            NameSurname = model.NameSurname,
            SendDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
        });

        await _context.SaveChangesAsync();

        await Task.Delay(1600);
        
        return RedirectToAction("Index");
    }
}

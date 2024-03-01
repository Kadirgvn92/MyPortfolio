using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class ContactController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public ContactController(DbMyPortfolioContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var values = _context.TblContacts.ToList();
        return View(values);
    }
    public IActionResult DeleteContact(int id)
    {
        var values = _context.TblContacts.FirstOrDefault(x => x.ContactId == id);
        _context.TblContacts.Remove(values);
        _context.SaveChanges();
        return RedirectToAction("Index", "Contact");
    }
    public IActionResult ChangeToTrue(int id)
    {
        var values = _context.TblContacts.FirstOrDefault(x => x.ContactId == id);
        values.IsRead = true;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult ChangeToFalse(int id)
    {
        var values = _context.TblContacts.FirstOrDefault(x => x.ContactId == id);
        values.IsRead = false;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}

using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class ServiceController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public ServiceController(DbMyPortfolioContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var values = _context.TblServices.ToList();
        return View(values);
    }
    public IActionResult DeleteService(int id)
    {
        var values = _context.TblServices.FirstOrDefault(x => x.ServiceId == id);
        _context.TblServices.Remove(values);
        _context.SaveChanges();
        return RedirectToAction("Index", "Service");
    }
    [HttpGet]
    public IActionResult CreateService()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateService(CreateServiceViewModel service)
    {
        TblService ser = new TblService
        {
            Description = service.Description,
            ServiceIcon = service.ServiceIcon,
            Title = service.Title
        };
        _context.TblServices.Add(ser);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateService(int id)
    {
        var values = _context.TblServices.FirstOrDefault(x => x.ServiceId == id);
        if (values != null)
        {
            UpdateServiceViewModel model = new UpdateServiceViewModel
            {
                ServiceId = values.ServiceId,
                Description = values.Description,
                Title = values.Title,
                ServiceIcon = values.ServiceIcon
            };
            return View(model);
        }
        return View();
    }
    [HttpPost]
    public IActionResult UpdateService(UpdateServiceViewModel model)
    {
        var values = _context.TblServices.FirstOrDefault(x => x.ServiceId == model.ServiceId);
        if(values != null)
        {
            values.Title = model.Title;
            values.ServiceIcon = model.ServiceIcon; 
            values.Description = model.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}

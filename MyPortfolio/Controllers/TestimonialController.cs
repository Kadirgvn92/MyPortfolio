using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.Testimonial;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;
public class TestimonialController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public TestimonialController(DbMyPortfolioContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var values = _context.TblTestimonials.ToList();
        return View(values);
    }
    public IActionResult DeleteTestimonial(int id)
    {
        var values = _context.TblTestimonials.FirstOrDefault(x => x.TestimonialId == id);
        _context.TblTestimonials.Remove(values);
        _context.SaveChanges();
        return RedirectToAction("Index", "Testimonial");
    }
    [HttpGet]
    public IActionResult CreateTestimonial()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateTestimonial(CreateTestimonailViewModel Testimonial)
    {
        TblTestimonial pro = new TblTestimonial
        {
            ImageUrl = Testimonial.ImageUrl,
            Description = Testimonial.Description,
            NameSurname = Testimonial.NameSurname,
        };
        _context.TblTestimonials.Add(pro);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateTestimonial(int id)
    {
        var values = _context.TblTestimonials.FirstOrDefault(x => x.TestimonialId == id);
        if (values != null)
        {
            UpdateTestimonialViewModel model = new UpdateTestimonialViewModel
            {
                TestimonialId = values.TestimonialId,
                Description = values.Description,
                NameSurname = values.NameSurname,
                ImageUrl = values.ImageUrl
            };
            return View(model);
        }
        return View();
    }
    [HttpPost]
    public IActionResult UpdateTestimonial(UpdateTestimonialViewModel model)
    {
        var values = _context.TblTestimonials.FirstOrDefault(x => x.TestimonialId == model.TestimonialId);
        if (values != null)
        {
            values.NameSurname = model.NameSurname;
            values.ImageUrl = model.ImageUrl;
            values.Description = model.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
    public IActionResult ChangeToTrue(int id)
    {
        var values = _context.TblTestimonials.FirstOrDefault(x => x.TestimonialId == id); 
        values.Status = true;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult ChangeToFalse(int id)
    {
        var values = _context.TblTestimonials.FirstOrDefault(x => x.TestimonialId == id);
        values.Status = false;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}

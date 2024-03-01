using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;
using MyPortfolio.Models.Project;

namespace MyPortfolio.Controllers;
public class ProjectController : Controller
{
    private readonly DbMyPortfolioContext _context;

    public ProjectController(DbMyPortfolioContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var values = _context.TblProjects.ToList();
        return View(values);
    }
    public IActionResult DeleteProject(int id)
    {
        var values = _context.TblProjects.FirstOrDefault(x => x.ProjectId == id);
        _context.TblProjects.Remove(values);
        _context.SaveChanges();
        return RedirectToAction("Index", "Project");
    }
    [HttpGet]
    public IActionResult CreateProject()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateProject(CreateProjectViewModel Project)
    {
        TblProject pro = new TblProject
        {
            ImageUrl = Project.ImageUrl,
            Description = Project.Description,
            Title = Project.Title,
            ProjectUrl = Project.ProjectUrl,
            ProjectCategory = 1
            
        };
        _context.TblProjects.Add(pro);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateProject(int id)
    {
        var values = _context.TblProjects.FirstOrDefault(x => x.ProjectId == id);
        if (values != null)
        {
            UpdateProjectViewModel model = new UpdateProjectViewModel
            {
                ProjectId = values.ProjectId,
                Description = values.Description,
                Title = values.Title,
                ProjectUrl = values.ProjectUrl,
                ImageUrl = values.ImageUrl,
                ProjectCategory = 1
            };
            return View(model);
        }
        return View();
    }
    [HttpPost]
    public IActionResult UpdateProject(UpdateProjectViewModel model)
    {
        var values = _context.TblProjects.FirstOrDefault(x => x.ProjectId == model.ProjectId);
        if (values != null)
        {
            values.Title = model.Title;
            values.ProjectUrl = model.ProjectUrl;
            values.ProjectCategory = 1;
            values.ImageUrl = model.ImageUrl;
            values.Description = model.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}

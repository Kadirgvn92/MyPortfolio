namespace MyPortfolio.Models.Project;

public class CreateProjectViewModel
{
    public int ProjectId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? ProjectUrl { get; set; }

    public int? ProjectCategory { get; set; }
}

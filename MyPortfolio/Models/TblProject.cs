using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblProject
{
    public int ProjectId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? ProjectUrl { get; set; }

    public int? ProjectCategory { get; set; }

    public virtual TblCategory? ProjectCategoryNavigation { get; set; }
}

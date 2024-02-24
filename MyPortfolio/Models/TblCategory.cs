using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblCategory
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TblProject> TblProjects { get; set; } = new List<TblProject>();
}

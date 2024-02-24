using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblService
{
    public int ServiceId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ServiceIcon { get; set; }
}

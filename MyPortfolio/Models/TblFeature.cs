using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblFeature
{
    public int FeatureId { get; set; }

    public string? Header { get; set; }

    public string? NameSurname { get; set; }

    public string? Title { get; set; }
}

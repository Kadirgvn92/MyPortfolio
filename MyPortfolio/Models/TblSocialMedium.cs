using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblSocialMedium
{
    public int? SocialMediaId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? IconUrl { get; set; }
}

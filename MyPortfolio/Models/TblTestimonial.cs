using System;
using System.Collections.Generic;

namespace MyPortfolio.Models;

public partial class TblTestimonial
{
    public int TestimonialId { get; set; }

    public string? NameSurname { get; set; }

    public string? ImageUrl { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }
}

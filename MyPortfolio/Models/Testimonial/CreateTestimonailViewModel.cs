namespace MyPortfolio.Models.Testimonial;

public class CreateTestimonailViewModel
{
    public int TestimonialId { get; set; }

    public string? NameSurname { get; set; }

    public string? ImageUrl { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; } = true;
}

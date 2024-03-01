namespace MyPortfolio.Models;

public class SendMessageViewModel
{
    public int ContactId { get; set; }

    public string? NameSurname { get; set; }

    public string? Email { get; set; }

    public string? Message { get; set; }

    public DateTime? SendDate { get; set; }

    public bool? IsRead { get; set; }

    public int? MessageCategory { get; set; }
}

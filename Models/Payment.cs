using System.ComponentModel.DataAnnotations;

namespace PaymentApi.Models;

public class Payment
{
    public int Id { get; set; }

    [Required]
    public string Payee { get; set; }

    [Range(0.01, 100000)]
    public decimal Amount { get; set; }

    public DateTime Date { get; set; } = DateTime.UtcNow;
}

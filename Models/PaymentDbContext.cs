using Microsoft.EntityFrameworkCore;
using PaymentApi.Models;

namespace PaymentApi;

public class PaymentDbContext : DbContext
{
    public PaymentDbContext(DbContextOptions<PaymentDbContext> options)
        : base(options) { }

    public DbSet<Payment> Payments => Set<Payment>();
}

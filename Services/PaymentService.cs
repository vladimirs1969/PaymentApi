using Microsoft.EntityFrameworkCore;
using PaymentApi.Models;

namespace PaymentApi.Services;

public class PaymentService : IPaymentService
{
    private readonly PaymentDbContext _context;

    public PaymentService(PaymentDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Payment>> GetAllAsync() =>
        await _context.Payments.ToListAsync();

    public async Task<Payment?> GetByIdAsync(int id) =>
        await _context.Payments.FindAsync(id);

    public async Task CreateAsync(Payment payment)
    {
        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(int id, Payment payment)
    {
        var existing = await _context.Payments.FindAsync(id);
        if (existing is null) return false;

        existing.Payee = payment.Payee;
        existing.Amount = payment.Amount;
        existing.Date = payment.Date;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var existing = await _context.Payments.FindAsync(id);
        if (existing is null) return false;

        _context.Payments.Remove(existing);
        await _context.SaveChangesAsync();
        return true;
    }
}

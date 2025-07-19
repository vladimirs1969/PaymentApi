using PaymentApi.Models;

namespace PaymentApi.Services;

public interface IPaymentService
{
    Task<IEnumerable<Payment>> GetAllAsync();
    Task<Payment?> GetByIdAsync(int id);
    Task CreateAsync(Payment payment);
    Task<bool> UpdateAsync(int id, Payment payment);
    Task<bool> DeleteAsync(int id);
}

using CleanArchitectureExample.Domain.Entities;

namespace CleanArchitectureExample.Application.Services
{
    public interface IValidationService
    {
        Task ValidateCustomerAsync(Customer customer);
    }
}

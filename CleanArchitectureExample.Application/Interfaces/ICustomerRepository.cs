using CleanArchitectureExample.Domain.Entities;

namespace CleanArchitectureExample.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
    }
}

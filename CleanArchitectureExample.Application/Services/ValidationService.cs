using CleanArchitectureExample.Domain.Entities;

namespace CleanArchitectureExample.Application.Services
{
    public class ValidationService : IValidationService
    {
        public Task ValidateCustomerAsync(Customer customer)
        {
            // Esegui logica di validazione
            if(string.IsNullOrWhiteSpace(customer.Name)) 
            { 
                throw new ArgumentException("Customer name cannot be empty"); 
            } 
            // Altri controlli di validazione
            return Task.CompletedTask;
        }
    }
}

using CleanArchitectureExample.Application.DTOs;
using CleanArchitectureExample.Application.Interfaces;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases
{
    public class CreateCustomer
    {
        private readonly ICustomerRepository _customerRepository; 
        private readonly IEmailService _emailService; 
        public CreateCustomer(ICustomerRepository customerRepository, IEmailService emailService) 
        { 
            _customerRepository = customerRepository; 
            _emailService = emailService; 
        }
        public async Task Execute(CreateCustomerDto dto) 
        { 
            var customer = new Customer(
                Guid.NewGuid(), 
                dto.Name, 
                new EmailAddress(dto.Email)
                ); 
            await _customerRepository.AddAsync(customer); 
            await _emailService.SendEmailAsync(customer.Email.Value, "Welcome", "Thank you for registering!"); 
        }
    }
}

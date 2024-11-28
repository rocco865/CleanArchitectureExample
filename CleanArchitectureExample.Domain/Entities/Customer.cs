using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public EmailAddress Email { get; private set; }
        public Customer(Guid id, string name, EmailAddress email) 
        { 
            Id = id; 
            Name = name; 
            Email = email; 
        }
    }
}

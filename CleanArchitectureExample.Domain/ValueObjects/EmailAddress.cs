using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Domain.ValueObjects
{
    public class EmailAddress
    {
        public string? Value { get; private set; }
        private EmailAddress() { }
        public EmailAddress(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) 
            { 
                throw new ArgumentException("Email address cannot be empty", nameof(value)); 
            } 
            // Aggiungi ulteriori validazioni se necessario
            Value = value; 
        }
    }
}

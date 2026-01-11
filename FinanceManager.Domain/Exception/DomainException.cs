using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException(string message) : base(message) { }
    }

    public class ValueIsNegative : System.Exception
    {
        public ValueIsNegative(string message, string paramName) : base($"{message}. Parameter name: {paramName}") { }
    }
}

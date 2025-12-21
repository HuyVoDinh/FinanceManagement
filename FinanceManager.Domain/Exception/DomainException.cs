using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain.Exception
{
    internal class DomainException : System.Exception
    {
        public DomainException(string message) : base(message) { }
    }
}

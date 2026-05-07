using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_7_5
{
    public class InsufficientFundsException : Exception
    {
        public double RequestedAmount { get; }

        public InsufficientFundsException(string message, double requestedAmount) : base(message)
        {
            RequestedAmount = requestedAmount;
        }
    }
}

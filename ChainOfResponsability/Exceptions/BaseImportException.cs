using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Exceptions
{
    abstract class BaseImportException : Exception
    {
        public BaseImportException(string message) : base(message)
        {
        }
        public override string Message => new StringBuilder().Append("Error: ").Append(base.Message).ToString();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Exceptions
{
    class NoChassisNumberException : BaseImportException
    {
        public NoChassisNumberException(string message) : base(message) { }

        public override string Message => new StringBuilder().Append("Error: ").Append(base.Message).ToString();
    }
}

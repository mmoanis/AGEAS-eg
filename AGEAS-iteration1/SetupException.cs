using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGEAS_iteration1
{
    class SetupException : Exception
    {
        public SetupException(string Message) : base(Message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyStat.Exceptions
{
    internal class UnknownParamNameException : Exception
    {
        internal UnknownParamNameException(string paramName)
            : base(string.Format("Unknown parameter: \"{0}\"", paramName))
        {
        }
    }
}

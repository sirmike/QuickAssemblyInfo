using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyStat.Interfaces
{
    interface IValueValidator
    {
        bool Validate(string value);
    }
}

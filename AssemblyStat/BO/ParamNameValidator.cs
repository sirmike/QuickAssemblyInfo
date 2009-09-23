using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssemblyStat.Interfaces;

namespace AssemblyStat.BO
{
    class ParamNameValidator : IValueValidator
    {
        internal readonly string[] AllowedParamNames;

        internal ParamNameValidator()
        {
            AllowedParamNames = new string[] { "assembly", "directory" };
        }

        #region IValueValidator Members

        public bool Validate(string value)
        {
            return AllowedParamNames.Contains(value);
        }

        #endregion
    }
}

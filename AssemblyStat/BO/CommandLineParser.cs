using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using AssemblyStat.Interfaces;
using AssemblyStat.Exceptions;
using System.Collections.Specialized;

namespace AssemblyStat.BO
{
    class CommandLineParser
    {
        public IValueValidator ParamNameValidator { get; set; }

        private void ValidateParamName(string type)
        {
            if (!ParamNameValidator.Validate(type))
            {
                throw new UnknownParamNameException(type);
            }
        }

        internal CommandLineParser()
        {
            ParamNameValidator = new ParamNameValidator();
        }

        internal KeyValuePair<string, string> ParseParam(string parameter)
        {
            if (parameter.StartsWith(" "))
            {
                throw new FormatException();
            }

            Regex regex = new Regex(string.Concat(@"^--(.+)=(.+)$"));
            Match match = regex.Match(parameter);

            if (!match.Success)
            {
                throw new UnknownParamNameException(parameter);
            }

            string paramName = match.Groups[1].Value;
            string paramValue = match.Groups[2].Value;

            ValidateParamName(paramName);

            KeyValuePair<string, string> result =
                new KeyValuePair<string, string>(
                    paramName,
                    paramValue);

            return result;
        }

        internal StringDictionary ParseParams(string parameters)
        {
            return ParseParams(parameters.Split(' '));
        }

        internal StringDictionary ParseParams(string[] parameters)
        {
            StringDictionary result = new StringDictionary();

            foreach (string p in parameters)
            {
                if (string.IsNullOrEmpty(p))
                {
                    continue;
                }
                KeyValuePair<string, string> parseResult = ParseParam(p);
                result.Add(parseResult.Key, parseResult.Value);
            }

            return result;
        }
    }
}

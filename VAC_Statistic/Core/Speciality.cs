using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace VAC_Statistic.Core
{
    class Speciality
    {
        public string Name;

        public int FirstCode { get; private set; }
        public int SecondCode { get; private set; }
        public int ThirdCode { get; private set; }

        public const string REGEX_PATTERN = @"^([0-9]*\.){2}[0-9]{2}$";
        public const string REGEX_PATTERN_IN_STRING = @"([0-9]*\.){2}[0-9]{2}[^0-9]";
        private const string REGEX_GET_NUMBERS = @"([0-9]*)";
        private string _code;
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (Regex.IsMatch(value, REGEX_PATTERN))
                {
                    _code = value;
                    parseCode(value);
                }
            }
        }

        public Speciality(string code)
        {
            this.Code = code;
        }

        private void parseCode(string code)
        {
            Regex re = new Regex(REGEX_GET_NUMBERS);

            var result = re.Matches(code);

            FirstCode = int.Parse(result[0].Value);
            SecondCode = int.Parse(result[2].Value);
            ThirdCode = int.Parse(result[4].Value);

        }


    }
}
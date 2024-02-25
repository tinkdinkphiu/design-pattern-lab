using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class IsValidDouble : IDataType
    {
        public bool IsValid(string input)
        {
            return double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }
    }
}

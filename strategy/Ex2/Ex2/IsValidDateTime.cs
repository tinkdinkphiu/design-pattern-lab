using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class IsValidDateTime : IDataType
    {
        public bool IsValid(string input)
        {
            return DateTime.TryParse(input, out _);
        }
    }
}

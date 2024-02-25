using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class IsValidString : IDataType
    {
        public bool IsValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}

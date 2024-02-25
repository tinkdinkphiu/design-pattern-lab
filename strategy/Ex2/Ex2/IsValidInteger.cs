using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class IsValidInteger : IDataType
    {
        public bool IsValid(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2
{
    internal class IsValidEmail : IDataType
    {
        public bool IsValid(string input)
        {
            string emailPattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            return Regex.IsMatch(input, emailPattern);
        }
    }
}

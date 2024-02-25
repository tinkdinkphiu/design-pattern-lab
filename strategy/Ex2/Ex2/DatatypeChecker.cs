using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class DatatypeChecker
    {
        public string input { get; set; }
        public IDataType datatype { get; set; }

        public bool IsValidDatatype()
        {
            return datatype.IsValid(this.input);
        }
    }
}

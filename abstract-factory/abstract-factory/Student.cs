using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    public class Student
    {
        public required string MSSV { get; set; }
        public string? FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? StudentClass { get; set; }
    }
}

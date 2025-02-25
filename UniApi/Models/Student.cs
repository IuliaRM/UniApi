using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniApi.Models
{
    public class Student
    {
        public int IDStudent { get; set; }
        public string NumeStudent { get; set; }
        public string CNP { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Email { get; set; }
        public int AnStudiu { get; set; }
    }
}
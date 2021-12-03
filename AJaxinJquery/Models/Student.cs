using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJaxinJquery.Models
{
    public class Student
    {
        public string ID{get; set;}

        public string Name { get; set; }

        public int Age { get; set; }
        public bool CheckedID { get; set; }
        public bool CheckedName { get; set; }
        public bool CheckedAge { get; set; }

    }
}
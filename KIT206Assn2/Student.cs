using System;
using System.Collections.Generic;
using System.Text;

namespace KIT206Assn2
{
    public class Student : Researcher
    {
        public String Degree { get; set; }
        public Staff Supervisor { get; set; }
        //or we can just use: public String supervisor { get; set; }
    }
}

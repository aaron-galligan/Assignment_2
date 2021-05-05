using System;
using System.Collections.Generic;
using System.Text;

namespace KIT206Assn2
{

    public enum EmploymentLevel { A, B, C, D, E}

    public class Position
    {
        public EmploymentLevel employmentLevel { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        
    }
}

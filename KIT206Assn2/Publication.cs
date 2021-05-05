using System;
using System.Collections.Generic;
using System.Text;

namespace KIT206Assn2
{
    public enum OutputType { Conference, Journal, Other}
    class Publication
    {
        public String Doi { get; set; }
        public String Title { get; set; }
        public String Authors { get; set; }
        public DateTime Year { get; set; } //sure if we want this as a DateTime or just an int
        public OutputType OutputType { get; set; }
        public DateTime Available { get; set; }

    }
}

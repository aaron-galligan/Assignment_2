using System;
using System.Collections.Generic;
using System.Text;

namespace KIT206Assn2
{
    pubic enum OutputType { Conference, Journal, Other}
    class Publication
    {
        public String doi { get; set; }
        public String title { get; set; }
        public String authors { get; set; }
        public DateTime year { get; set; } //sure if we want this as a DateTime or just an int
        public OutputType outputType { get; set; }
        public DateTime available { get; set; }

    }
}

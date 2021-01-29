using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordon_2
{
    class Fordon
    {
        public string tillverkare { get; set; }
        public string modell { get; set; }
        public int årsmodell { get; set; }
        public override string ToString()
        {
            return "tillverkare: " + tillverkare + "\nmodel: " + modell + "\nårsmodell: " + årsmodell;
        }
        public Fordon(String t, String m, int å)
        {
            tillverkare = t;
            modell = m;
            årsmodell = å;
        }
    }
}

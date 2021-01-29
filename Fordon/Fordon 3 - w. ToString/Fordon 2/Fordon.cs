using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordon_2
{
    class Fordon
    {
        private string Tillverkare;
        private string Modell;
        private int Årsmodell;
        public Fordon( String t, String m, int å)
        {
            Tillverkare = t;
            Modell = m;
            Årsmodell = å;
        }
        public override string ToString()
        {
            string output = "";
            output += "\nTillverkare: " + Tillverkare;
            output += "\nModell: " + Modell;
            output += "\nÅrsmodell: " + Årsmodell;
            return output;
        }
    }
}

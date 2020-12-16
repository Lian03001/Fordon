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

        public void setTillverkare(string t){Tillverkare = t;}
        public string getTillverkare(){return Tillverkare;}

        public void setModell(string m){Modell = m;}
        public string getModell(){return Modell;}

        public void setÅrsmodell(int å){Årsmodell = å;}
        public int getÅrsmodell(){return Årsmodell;}
    }
}

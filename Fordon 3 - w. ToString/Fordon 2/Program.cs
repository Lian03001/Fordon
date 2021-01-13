using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordon_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Fordon SAAB = new Fordon();
            //SAAB.setTillverkare("SAAB");
            //SAAB.setModell("95a");
            //SAAB.setÅrsmodell(99);

            //Console.WriteLine(SAAB.getTillverkare());
            //Console.WriteLine(SAAB.getModell());
            //Console.WriteLine(SAAB.getÅrsmodell());
            Fordon SAAB = new Fordon("SAAB", "95a", 99);

            Console.WriteLine(SAAB);
        }
    }
}

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
            List<Fordon> fordon = new List<Fordon>();
            fordon.Add(new Fordon("SAAB", "9-3", 08));
            foreach (Fordon e in fordon)
            {
                Console.WriteLine(e);
            }
        }
    }
}

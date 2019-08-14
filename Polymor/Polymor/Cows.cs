using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class Cows : Animal
    {
        static int counter = 0;
        public static List<string> Breeds = new List<string>()
        { "Fresian", "Angus", "Texas Longhorn"};
        public string MyBreed { get; set; }
        public Cows()
        { counter++; }
    }
}

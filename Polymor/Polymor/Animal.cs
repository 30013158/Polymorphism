using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class Animal
    {   //auto-properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //attribute is instantiated
        public List<Checkup> vetchecks = new List<Checkup>();

       
    }
}

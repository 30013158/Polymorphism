using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class Checkup
    {
        public string  Date { get; set; }
        public string Vet { get; set; }
        public string Notes { get; set; }
       public Checkup(string date, string vet, string notes)
        {
           
            Date = date;
            Vet = vet;
            Notes = notes;

        }
    }
}

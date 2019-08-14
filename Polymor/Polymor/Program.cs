using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymor
{
    class Program
    {
        static void Main(string[] args)
        {
            Cows c1 = new Cows();
            c1.Name = "Jake the cow";
            c1.Id = 1234;
            c1.Age = 10;
            c1.MyBreed = Cows.Breeds[0];

            Checkup check = new Checkup("14/08/2019", "Tom", "animal is healthy");
            c1.vetchecks.Add(check);
            c1.vetchecks.Add(new Checkup("12/08/2019", "You", "animal is recovering .."));

            Console.WriteLine($"Name: {c1.Name}\nAge:{c1.Age}\nBreed: {c1.MyBreed}");
            Console.WriteLine("\nVet check details ...");
            foreach(Checkup x in c1.vetchecks)
             Console.WriteLine($"Date: {x.Date}\nVet:{x.Vet}\n Notes: {x.Notes}");
                Console.ReadLine();
            


        }
    }
}

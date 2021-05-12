using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet Jackie = new Pet("Jackie", 5, "Fat and fluffy");
            Console.WriteLine(Jackie);
            Jackie.SetOwner("Ali");
            Console.WriteLine(Jackie);
            Jackie.Train();
            Console.WriteLine(Jackie);
            Console.WriteLine();
            Pet Suzy = new Pet("Suzy", 3, "Brown and skinny");
            Console.WriteLine(Suzy);
            Suzy.SetOwner("John");
            Console.WriteLine(Suzy);
            Suzy.Train();
            Console.WriteLine(Suzy);
            Console.WriteLine();
            Pet Sizzy = new Pet("Sizzy", 2, "Big and hairy");
            Console.WriteLine(Sizzy);
            Sizzy.SetOwner("Andre");
            Console.WriteLine(Sizzy);
            Sizzy.Train();
            Console.WriteLine(Sizzy);
            Console.WriteLine();
            Pet Pimmy = new Pet("Pimmy", 1, "Tiny");
            Console.WriteLine(Pimmy);
            Pimmy.SetOwner("John");
            Console.WriteLine(Pimmy);
            Pimmy.Train();
            Console.WriteLine(Pimmy);
            Console.WriteLine();
            List<Pet> pets = new List<Pet>();
            pets.Add(Jackie); pets.Add(Suzy); pets.Add(Sizzy); pets.Add(Pimmy);
            Console.WriteLine("Pets that their owner is John:");
            foreach (Pet pet in pets)
            {
                if (pet.Owner=="John")
                {
                    Console.WriteLine(pet);
                }
            }




        }
    }
}

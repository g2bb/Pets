﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    class Program {
        static void Main() {
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);
            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.readTag() + "\n");

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);
            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.readTag());
            Console.WriteLine(dog1.bark(4) + "\n");

            Cat cat1 = new Cat("Simba", "Maria", 5.2);
            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.readTag());
            Console.WriteLine(cat1.meow(3) + "\n");
        }
    }
}

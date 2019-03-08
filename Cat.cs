using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    class Cat : Pet {
        public Cat(string name, string owner, double weight) : base("Cat", name, owner, weight) { }

        public string meow(int count) {
            string number = "";
            for (int i = 0; i < count; i++) {
                number += "Meow! ";
            }
            return number;
        }
    }
}
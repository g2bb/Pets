using System;

namespace Pets {
    class Pet {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet (string type, string name, string owner, double weight) {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string readTag() {
            return String.Format("If lost, please call {0}", this.owner);
        }
    }
}

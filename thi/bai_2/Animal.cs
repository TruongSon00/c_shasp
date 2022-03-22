using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public abstract class Animal
    {
        public string name;
        public float weight;
        public Animal() { }
        public Animal(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public abstract string show();


        public void SetMe(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}

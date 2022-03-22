using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public class Lion : Animal
    {
        public Lion(string name, float weight) : base(name, weight) { }
        public Lion() { }
        public override string show()
        {
            return $"Name: {name}, Weight: {weight}, keu: gram... gram";
        }
    }
}

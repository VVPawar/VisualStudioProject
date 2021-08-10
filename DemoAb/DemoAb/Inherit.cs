using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoAb
{
    class Inherit:Sum
    {
        public void display() {
            Console.WriteLine(sum(10, 30));
        }
        public override int mult(int i,int j) {
            return i * j;
        }
    }
}

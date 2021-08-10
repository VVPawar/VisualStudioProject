using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoAb
{
    public abstract class Sum
    {
        public int sum(int i, int j) {
            return i + j;
        }
        public abstract int mult(int i, int j);
    }
}

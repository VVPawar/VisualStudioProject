using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class MultiBase:MultiChild
    {
        public void getData() {
            String z = Parent();
            String y = ChildClass();
        }
    }
}

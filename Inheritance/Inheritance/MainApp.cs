using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inheritance;

namespace Inheritance
{
    class MainApp
    {
       
        static public void Main(String[] args)
        {
            SingleMain sm = new SingleMain();
            sm.display();
            MultiBase MB = new MultiBase();
            MB.getData();
        }
       
    }
}

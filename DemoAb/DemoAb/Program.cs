using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoAb
{
    class Program
    {
        static void Main(string[] args)
        {
            Inherit i = new Inherit();
            i.display();
            Console.WriteLine(i.sum(10,20));
            Thread.Sleep(5000);
        }
    }
}

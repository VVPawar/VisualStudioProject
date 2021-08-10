using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                customer2 cs = new customer2();
                cs.WithdrawaAmount();
                cs.AddAmount();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}

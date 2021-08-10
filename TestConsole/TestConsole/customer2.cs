using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class customer2: BankWithdrawal,bankDeposits
    {
       public int TotalWithAmount()
        {
            return 100;
        }
        public void WithdrawaAmount() {
           Console.WriteLine(TotalWithAmount());
        }
        public void AddAmount()
        {

            int total = TotalAmount() - 100;
            Console.WriteLine(total);
        }
        public int TotalAmount() {
            return 1000-TotalWithAmount();
        }
    }
}

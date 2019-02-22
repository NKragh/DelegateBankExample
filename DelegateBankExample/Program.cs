using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account NikolajsAccount = new Account(true);

            NikolajsAccount.AccountDeposit = NikolajsAccount.Add;

            Console.WriteLine(NikolajsAccount.AccountDeposit(3));
            Console.WriteLine(NikolajsAccount.AccountDeposit(99000));

            Account JohanAccount = new Account(false);

            JohanAccount.AccountDeposit = JohanAccount.Add;

            Console.WriteLine(JohanAccount.AccountDeposit(49999));
            Console.WriteLine(JohanAccount.AccountDeposit(50001));
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            NikolajsAccount.AccountWithdrawal = NikolajsAccount.Subtract;
            Console.WriteLine("Standard: \t" + NikolajsAccount.AccountDeposit(50001) + "\n");
            Console.WriteLine("Standard: \t" + NikolajsAccount.AccountWithdrawal(50001) + "\n");
            NikolajsAccount.AccountDeposit = NikolajsAccount.AddMasterRace;
            NikolajsAccount.AccountWithdrawal = NikolajsAccount.SubtractMax;
            Console.WriteLine("Masterrace: \t" + NikolajsAccount.AccountDeposit(50001) + "\n");
            Console.WriteLine("Max: \t\t" + NikolajsAccount.AccountWithdrawal(50001) + "\n");
            Account JohanAccount = new Account(false);
            JohanAccount.AccountDeposit = JohanAccount.Add;
            JohanAccount.AccountWithdrawal = JohanAccount.Subtract;
            Console.WriteLine("Standard: \t" + JohanAccount.AccountDeposit(50001) + "\n");
            Console.WriteLine("Standard: \t" + JohanAccount.AccountWithdrawal(50002) + "\n");
            JohanAccount.AccountDeposit = JohanAccount.AddPeasant;
            JohanAccount.AccountWithdrawal = JohanAccount.SubtractLimit;
            Console.WriteLine("Peasant: \t" + JohanAccount.AccountDeposit(50001) + "\n");
            Console.WriteLine("Peasant: \t" + JohanAccount.AccountDeposit(1) + "\n");
            Console.WriteLine("Limit: \t" + JohanAccount.AccountWithdrawal(1) + "\n");
        }
    }
}

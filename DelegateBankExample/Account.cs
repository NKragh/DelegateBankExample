using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBankExample
{
    class Account
    {
        private int _balance;
        private bool _medarbejder;

        public delegate int Deposit(int deposit);
        public delegate int Withdrawal(int withdrawal);

        public Deposit AccountDeposit;
        public Withdrawal AccountWithdrawal;

        public Account(bool medarbejder)
        {
            _medarbejder = medarbejder;
        }
        public int Add(int deposit)
        {
            if (_medarbejder == false && deposit > 50000)
            {
                Console.WriteLine("Du sætter meget ind mester. Tror du ikke du skulle ringe til SKAT?");
            }
            else if (_medarbejder == true && deposit > 100000)
            {
                Console.WriteLine("Du sætter vist lidt meget ind mesterløgsovs.");
            }
            else
            {
                _balance += deposit;

            }
            return Balance;
        }

        public int Balance
        {
            get { return _balance; }
        }

        public bool Medarbejder
        {
            get { return _medarbejder; }
            set { _medarbejder = value; }
        }
    }
}

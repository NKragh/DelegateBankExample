using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

        public bool ActivateMoneyLaundryAlert()
        {
            if (AccountDeposit == null)
            {
                AccountDeposit = AddPeasant;
                return true;

            }
            return false;
        }
        public bool DeActivateMoneyLaundryAlert()
        {
            if (AccountDeposit == AddPeasant)
            {
                AccountDeposit = Add;
                return true;

            }
            return false;
        }

        private int Add(int amount)
        {
            _balance += amount;
            return _balance;
        }

        private int AddMasterRace(int amount)
        {
            if (_medarbejder == true && amount > 100000)
            {
                Console.WriteLine("Du sætter vist lidt meget ind mesterløgsovs.");
            }
            else
            {
                _balance += amount;
            }
            return _balance;
        }

        private int AddPeasant(int amount)
        {
            if (_medarbejder == false && amount > 50000)
            {
                Console.WriteLine("Du sætter meget ind mester. Tror du ikke du skulle ringe til SKAT?");
            }
            else
            {
                _balance += amount;
            }
            return _balance;
        }

        private int Subtract(int amount)
        {
            _balance -= amount;
            return _balance;
        }

        private int SubtractMax(int amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("Så meget kan du vist ikke trække ud mester.");
            }
            else
            {
                _balance -= amount;
            }
            return _balance;
        }

        private int SubtractLimit(int amount)
        {
            if ((_balance - amount) < 0)
            {
                Console.WriteLine("Åh åååh. Du har ikke nok indestående til at trække så meget ud.");
            }
            else
            {
                _balance -= amount;
            }
            return _balance;
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

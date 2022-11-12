using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Saturday_Lab
{
    internal class BankApp
    {
        public int Acc_no { get; set; }
        public string Name { get; set; }
        public int MobileNumber { get; set; }
        public int Amount { get; set; }
        private int Balance { get; set; }

        public BankApp()
        {
            Balance = 0;    
        }

        public void Create() {
            Console.WriteLine("Enter the Account number : ");
            Acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Mobile number : ");
            MobileNumber = int.Parse(Console.ReadLine());
        }

        public void Deposit() {
            Console.WriteLine("Enter the Amount to be deposited : ");
            Amount = int.Parse(Console.ReadLine());
            Balance = Balance + Amount;
        }

        public void Withdraw() { 
            Console.WriteLine("Enter the Amount to be withdrawed : ");
            Amount = int.Parse(Console.ReadLine());
            Balance = Balance - Amount;
        }

        public void BalanceIn() { 
        Console.WriteLine($"The Balance amount : {Balance}");
        }
    }
}

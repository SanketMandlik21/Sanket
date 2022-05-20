using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritan.In
{
    internal class Bank
    {
        int AccountN;
        int BankID;
        string Name;

        public Bank()
        {

        }
        public Bank(int accountN, int bankID, string name)
        {
            AccountN = accountN;
            BankID = bankID;
            Name = name;
        }

        public int AccountN1 { get => AccountN; set => AccountN = value; }
        public int BankID1 { get => BankID; set => BankID = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}

using BankKonto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankHolder
{
   public static class BankData
    {

        public static readonly Bank davidsBank = new Bank
        {
            bankName = "ICA BANK",
            bankAccount = "141- 5100",
            bankUser = "David Vink",
            bankBalance = 12401.40f
        };

        public static readonly Bank linasBank = new Bank
        {
            bankName = "COOP BANK",
            bankAccount = "034- 0318",
            bankUser = "Lina Fina",
            bankBalance = 0.0f
        };

        public static readonly Bank markosBank = new Bank
        {
            bankName = "COOP BANK",
            bankAccount = "102- 3014",
            bankUser = "Marko Spaghetti",
            bankBalance = 32030.0f
        };

        public static readonly Bank tostesBank = new Bank
        {
            bankName = "WILLYS BANK",
            bankAccount = "18 - 1694",
            bankUser = "Toste Floss",
            bankBalance = 6043.50f
        };

        // Find all objects of type Bank and make a list
        public static List<Bank> AllAccounts => typeof(BankData).GetFields(BindingFlags.Static | BindingFlags.Public).Where(f => f.FieldType == typeof(Bank)).Select(f => (Bank)f.GetValue(null)).ToList();
    }
}

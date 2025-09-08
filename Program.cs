using BankHolder;

namespace BankKonto;

internal partial class Program
{
    static void Main(string[] args)
    {
        foreach (var bank in BankData.AllAccounts)
        {
            bank.DisplayUserInformation();
            Console.WriteLine();
        }
        Console.ReadLine();
        Console.WriteLine();

        
        BankData.davidsBank.TransferTo(BankData.linasBank, 304.50f);
        Console.ReadLine();
        Console.WriteLine();

        BankData.linasBank.TransferTo(BankData.tostesBank, 1000.0f);
        Console.ReadLine();
        Console.WriteLine();

        BankData.davidsBank.TransferTo(BankData.linasBank, 304.50f);
        Console.ReadLine();
        Console.WriteLine();


        Console.WriteLine(BankData.markosBank.CheckInvestmentGrowth(1000.0f, BankData.davidsBank, 4));
        Console.WriteLine(BankData.markosBank.CheckInvestmentGrowth(1000.0f, BankData.linasBank, 4));
        Console.WriteLine(BankData.markosBank.CheckInvestmentGrowth(1000.0f, BankData.tostesBank, 4));
        Console.ReadLine();
        Console.WriteLine();

        
        BankData.tostesBank.ChangeBankUser("Tomas Lundell");
        Console.ReadLine();
        Console.WriteLine();
    }

}

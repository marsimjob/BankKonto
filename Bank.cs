namespace BankKonto

{
        public class Bank
        {

            // ATTRIBUT ----------------------------------------------------------------------------------------
            public string bankName;
            public string bankAccount;
            public string bankUser;
            private string bankAdmin = "Secret Admin";
            public float bankBalance;
            //--------------------------------------------------------------------------------------------------
           
            
            // METODER -----------------------------------------------------------------------------------------
            //Transfer Money
            public void TransferTo(Bank receiver, float amount)
            {
                if (this.bankBalance >= amount)
                {
                    this.bankBalance -= amount;
                    receiver.bankBalance += amount;
                    Console.WriteLine($"{this.bankUser} transferred {amount}kr to {receiver.bankUser}.");
                    Console.WriteLine($"{this.bankUser} current balance: " +
                        $"{this.bankBalance}kr || {receiver.bankUser} current balance: {receiver.bankBalance}kr");
                }
                else
                {
                    Console.WriteLine($"{this.bankUser} does not have enough funds.");
                }
            }


            public float CheckInvestmentGrowth(float moneyinserted, Bank investmentBank, int yearsSaved)
            {
                float growthRate;

                if (investmentBank.bankName == "ICA BANK")
                    growthRate = 1.09f;
                else if (investmentBank.bankName == "COOP BANK")
                    growthRate = 1.07f;
                else if (investmentBank.bankName == "WILLYS BANK")
                    growthRate = 1.12f;
                else
                {
                    growthRate = 1f;
                }
                    return moneyinserted * growthRate * yearsSaved;
            }

            // Change Bank User
            public void ChangeBankUser(string newUser)
            {
                bankUser = newUser;
            }

            public void DisplayUserInformation()
            {
                Console.WriteLine($"BANK: {this.bankName}");
                Console.WriteLine($"ACCOUNT NUMBER: {this.bankAccount}");
                Console.WriteLine($"BALANCE: {this.bankBalance}");
                Console.WriteLine($"USER:{this.bankUser} ");
            }
            //--------------------------------------------------------------------------------------------------
    }
}
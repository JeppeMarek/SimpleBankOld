namespace SimpleBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccOne = new BankAccount("NemKonto", 500, true);
            BankAccount bankAccTwo = new BankAccount("Besværlig konto", 5);
            BankAccount bankAccThree = new BankAccount(5000);

            //Console.WriteLine(bankAccOne.ToString());
            //Console.WriteLine(bankAccTwo.ToString());
            //Console.WriteLine(bankAccThree.ToString());
            //bankAccThree.Deposit(500);
            //Console.WriteLine(bankAccThree.ToString());
            //bankAccThree.Withdraw(7000);
            //Console.WriteLine(bankAccThree.ToString());
            //bankAccThree.ChangeLockState();
            //Console.WriteLine(bankAccThree.ToString());
            BankAccount BobsAccount = new BankAccount(5000);
            BobsAccount.Name = "Bob";
            Console.WriteLine(BobsAccount);


        }
    }
}
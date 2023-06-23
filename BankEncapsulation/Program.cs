namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account=new BankAccount();
            Console.WriteLine("Please deposit the money");
            var AmountToDeposit=double.Parse(Console.ReadLine());
            account.Deposit(AmountToDeposit);
            Console.WriteLine("your balance is " + account.GetBalance());
        }
    }
}

namespace Repetition_7_5
{
    public class Account
    {
        public string Owner { get; }
        public double Balance { get; private set; }
        public Account(string owner, double initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException("The balance on your account is too low to withdraw that amount!", amount);
            }
            Balance -= amount;
        }
    }
}

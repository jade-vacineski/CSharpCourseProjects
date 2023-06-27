namespace Course
{
    class Account
    {

        public string Holder { get; set; }
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public double InitialDeposit { get; }

        public Account(int accountNumber, string holder)
        {
            Holder = holder;
            AccountNumber = accountNumber;
        }

        public Account(int accountNumber, string holder, double balance) : this(accountNumber, holder)
        {
            Balance = balance;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }
        public void Withdraw(double value)
        {
            if (Balance > 0)
            {
                Balance -= value;
            }
        }
        override public string ToString()
        {
            return AccountNumber
            + ", " + Holder
            + ", " + Balance;

        }
    }
}
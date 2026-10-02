using Bank;

namespace Main
{
    internal class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal intialBalance) : base(name, intialBalance) { }

        //override в дочернем классе позволяет определить новую реализацию PerformMonthAndTransactions
    public override void PerformMonthAndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.02m;
                MakeDeposit(interest, DateTime.UtcNow, "Apply month interest");
            }
        }
    }
}
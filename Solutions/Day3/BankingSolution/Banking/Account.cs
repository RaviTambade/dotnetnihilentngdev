namespace Banking;

public class Account
{
    //KISS
    // Property to get the account balance

    //Auto Property
    public decimal Balance { get; set; }

    public event AccountOperation underBalance;
    public void Withdraw(decimal amount)
    {
        // Logic for withdrawing money
        if (amount > 0 && amount <= Balance)
        {
           decimal tempAmount= Balance- amount;
           if (tempAmount < 10000)
           {
               underBalance();  //trigger event
           }
           Balance = tempAmount;
        }
    }

    public void Deposit(decimal amount)
    {
        // Logic for depositing money
        if (amount > 0)
        {
            Balance += amount;
        }
    }

}

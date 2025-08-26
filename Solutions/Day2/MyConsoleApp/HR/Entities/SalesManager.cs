namespace HR;

public sealed class SalesManager : SalesEmployee
{
    private decimal bonus;

    public void SetBonus(decimal bonus)
    {
        this.bonus = bonus;
    }

    public decimal GetBonus()
    {
        return bonus;
    }

    //Constructor overloading
    public SalesManager() : base()
    {
        this.bonus = 0.0m;
    }
    public SalesManager(string name, int id, decimal salesTarget, decimal bonus) : base(name, id, salesTarget)
    {
        this.bonus = bonus;
    }

    public decimal ComputeTotalPay()
    {
        return ComputePay() + bonus;
    }
}
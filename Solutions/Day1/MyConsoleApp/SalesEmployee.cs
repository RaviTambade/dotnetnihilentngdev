namespace HR;

public class SalesEmployee : Employee
{
    private decimal salesTarget;

    public void SetSalesTarget(decimal salesTarget)
    {
        this.salesTarget = salesTarget;
    }

    public decimal GetSalesTarget()
    {
        return salesTarget;
    }

    //Constructor overloading
    public SalesEmployee() : base()
    {
        this.salesTarget = 0.0m;
    }
    public SalesEmployee(string name, int id, decimal salesTarget) : base(name, id)
    {
        this.salesTarget = salesTarget;
    }


    public override decimal ComputePay()
    {
        return salesTarget * 0.1m;
    }
}
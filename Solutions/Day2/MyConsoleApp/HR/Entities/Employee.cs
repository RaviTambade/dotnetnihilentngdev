namespace  HR;

public  abstract  class Employee
{
    private string name;
    private int id;

    protected int empId;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public int GetId()
    {
        return id;
    }

    //Constructor overloading
    public Employee()
    {
        this.name = string.Empty;
        this.id = 0;
    }
    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public abstract decimal ComputePay(); //prototype
}
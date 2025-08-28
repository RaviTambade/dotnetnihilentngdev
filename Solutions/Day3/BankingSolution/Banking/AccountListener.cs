
namespace Banking.Handlers;


//Utility Class
//Helper Class
public static class AccountListener
{
    public static   void BlockAccount()
    {
        Console.WriteLine($"Account blocked due to suspicious activity");
    }

    public static  void SendEmail()
    {
        Console.WriteLine($"Email sent regarding account activity");
    }

}
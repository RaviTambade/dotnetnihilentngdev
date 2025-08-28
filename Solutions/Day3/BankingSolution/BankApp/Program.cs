
using Banking;
using Banking.Handlers;

Account acct123 = new Account();
//Register event handlers with event before any operation take place
acct123.underBalance += AccountListener.BlockAccount;
acct123.underBalance += AccountListener.SendEmail;

acct123.Balance = 67000;
acct123.Withdraw(66000);




/*//Direct Call
AccountListener.BlockAccount();
AccountListener.SendEmail();
*/


//Multicasting
/*AccountOperation agent = new AccountOperation(AccountListener.BlockAccount);
agent += AccountListener.SendEmail;
agent(); //indirect call to all methods which are registered
*/

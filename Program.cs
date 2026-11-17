// using System;

// namespace depepndinj

// {

// class EmailService
// {
//    public void SendMessage()
// 	{
// 	  Console.WriteLine("Order confirmation email has been sent");
// 	}
// }

// class WhatsappService
// {
// 	public void SendMessage()
//         {
// 	  Console.WriteLine("order confirmation whatsapp message has been sent");
//         }
// }
// class SmService
// {
// 	public void SendMessage()
// 	{
// 	  Console.WriteLine("order confirmation sms has been sent");
// 	}
// }
// class program
// {

//   private EmailService email = new EmailService();
//   private WhatsappService what = new WhatsappService();
//   private SmService sms = new SmService();

//   public static void Main(String[] args)
//     {
// 	program p = new program();
// 	p.PlaceOrder();
//      }

// 	public void PlaceOrder()
//          {
	
// 		Console.WriteLine("order placed successfully");
// 		email.SendMessage();
// 		what.SendMessage();
// 		sms.SendMessage();

// 	}
   
//  }
// }

// //this is an example of a tight coupling now well refactor using dependency injection
// // currently you cannot test individual components
// //it is tight coupling because o fdirect instantiation (new keyword)


using System;

namespace dependinj
 {
   interface IMessageService
   {
	void SendMessage();
   }
class EmailService : IMessageService
  {	
	public void SendMessage()
	{ Console.WriteLine("order confirmation Email sent");}
  }

interface IPaymentServ
  {
	void MakePayment();
  }

class CashPaymentSe : IPaymentServ
  { 
    public void MakePayment()
	{
           Console.WriteLine("cash payment received ");
	}
 }
   class program 
    {
	private IMessageService _service;
	private IPaymentServ _serv;

	public program(IMessageService service, IPaymentServ serv)
	{
		_service = service;
		_serv = serv;
	}
	
	
     public static void Main(string[] args)
	{
	  Console.WriteLine("testind gependency injection");
	  IMessageService nserv = new EmailService();
	  IPaymentServ nserv2 = new CashPaymentSe();
	
	  program p = new program(nserv,nserv2);
	   
	  p.PlaceOrder();
	  p.MakePay();
	}
	public void MakePay()
	{
	 _serv.MakePayment();
	}
	public void PlaceOrder()
	{	
	  Console.WriteLine("order has been placed successfully");
	  _service.SendMessage();
	}
    }
}
using System.Net.Mail;
using System.Net;

Console.Write("Enter your mail (must be ...outlook.com):");
string mymail = Console.ReadLine();
Console.Write("Enter your password:");
string mypassword = Console.ReadLine();

#region Send
Console.WriteLine("\n");
Console.Write("Mail To: ");
string mail_to = Console.ReadLine();

Console.Write("Subject: ");
string subject = Console.ReadLine();

Console.Write("Body: ");
string body = Console.ReadLine();
#endregion

MailMessage mail = new MailMessage();
mail.From = new MailAddress(mymail);
mail.To.Add(mail_to);
mail.Subject = subject;
mail.Body = body;

SmtpClient smtp = new SmtpClient();
smtp.Credentials = new NetworkCredential(mymail, mypassword);
smtp.Host = "smtp.outlook.com";
smtp.Port = 587;
smtp.EnableSsl = true;
smtp.Send(mail);

Console.WriteLine("\n*Mail was sent successfully*");






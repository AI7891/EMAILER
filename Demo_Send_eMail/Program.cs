// See https://aka.ms/new-console-template for more information
using MimeKit;
using System.Net.Mail;

Console.WriteLine("Hello, World!");


/*Using Mailkit Demo*/

/*Config*/

string smtpHost = "localhost";
int smtpPort = 25;
string appEmail = "no-reply@demo.be";
string appName = "Demo App";

/*Mail Set-Up*/
/* Subject Message Setting Up*/
MimeMessage message = new MimeMessage();
message.From.Add(new MailboxAddress(appName, appEmail));
message.To.Add(new MailboxAddress("Vladimir", "v.brasseur@bruxellesformation.brussels"));
message.Subject = "Hello world";

/*email content bodyEmail addition*/
BodyBuilder bodyEmail = new BodyBuilder();

bodyEmail.TextBody = "";
bodyEmail.HtmlBody = @"";

message.Body = bodyEmail.ToMessageBody();

/*Sending the email*/
using (SmtpClient smtpClient = new SmtpClient())
{
    smtpClient
}

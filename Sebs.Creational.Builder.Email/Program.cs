namespace Sebs.Creational.Builder.Email
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Email object CreationalBuilder using CreationalBuilder
            EmailBuilder emailCreationalBuilder = new EmailBuilder();
            var emailModel = emailCreationalBuilder
                .To("\t\t abc@email.com")
                .From("\t\t xyz@email.com")
                .Subject("\t Email subject")
                .Body("\t Email body")
                .Build();

            //Email Screen
            Console.WriteLine($"Email Builder: " +
                $"\n\t From: {emailModel.From} " +
                $"\n\t To: {emailModel.To} " +
                $"\n\t Subject: {emailModel.Subject} " +
                $"\n\t Content: {emailModel.Body}\n");

            Console.ReadLine();
        }
    }
}
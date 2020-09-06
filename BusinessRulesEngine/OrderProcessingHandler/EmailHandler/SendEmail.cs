namespace BusinessRulesEngine
{
    using System;

    public class SendEmail: ISendEmail
    {
        public void SendEmailToMember(string membershipType)
        {
            switch (membershipType)
            {
                case "upgrade":
                    Console.WriteLine("Membership Upgraded email sent to member");
                    break;
                default:
                    Console.WriteLine("Membership Activated email sent to member");
                    break;
            }
        }
    }
}

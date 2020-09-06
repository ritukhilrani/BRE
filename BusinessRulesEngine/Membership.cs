namespace BusinessRulesEngine
{
    using System;

    public class Membership
    {
        private static string _successfulMessage;
        private readonly ISendEmail _sendEmail;

        public Membership(ISendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public string ActivateMembership(string inputOrder)
        {
            try
            {
                if (inputOrder.Contains("new"))
                {
                    _successfulMessage = "Membership activated and email sent";
                    _sendEmail.SendEmailToMember("new");
                }
                else
                {
                    _successfulMessage = "Membership Upgraded and email sent";
                    _sendEmail.SendEmailToMember("upgrade");
                }
                return _successfulMessage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Email sending failed");
            }

            return null;
        }
    }
}

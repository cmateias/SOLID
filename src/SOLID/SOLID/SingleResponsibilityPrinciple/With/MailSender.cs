﻿namespace SOLID.SingleResponsibilityPrinciple.With
{
    public class MailSender
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }

        public void SendEmail()
        {
            //TODO code for sending the email
        }
    }
}
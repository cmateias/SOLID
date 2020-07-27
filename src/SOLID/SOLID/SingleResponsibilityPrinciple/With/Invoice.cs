using System;

namespace SOLID.SingleResponsibilityPrinciple.With
{
    public class Invoice
    {
        private readonly MailSender emailSender;
        private readonly ILogger fileLogger;

        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }

        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");
                // TODO code for adding the invoice
                emailSender.EMailFrom = "emailfrom@me.com";
                emailSender.EMailTo = "emailto@me.com";
                emailSender.EMailSubject = "Single Responsibility Principle";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //TODO code for removing the invoice
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}
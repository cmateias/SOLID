using System;
using System.IO;
using System.Net.Mail;

namespace SOLID.SingleResponsibilityPrinciple.Without
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvDate { get; set; }

        public void AddInvoice()
        {
            try
            {
                var mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //TODO Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                //TODO Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
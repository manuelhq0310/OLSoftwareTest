using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;
using TestAPIRest.Models;

namespace TestAPIRest.Services
{
    public class SendGridService
    {
        const string API_KEY = "API_KEY";

        public string SendEmail(SendEmail requestSendEmail)
        {            
            try
            {
                if (requestSendEmail != null)
                {
                    return SendSendgridEmail(requestSendEmail).Result;
                }
                else
                {
                    throw new Exception("requestSendEmail cannot be null.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Service SendEmail Exception: " + ex.Message, ex);
            }
        }

        private async Task<string> SendSendgridEmail(SendEmail sendEmail)
        {
            var client = new SendGridClient(API_KEY);

            var msg = new SendGridMessage
            {
                From = new EmailAddress(sendEmail.FromEmail, sendEmail.NameEmail),
                Subject = sendEmail.Subject,
                HtmlContent = sendEmail.Body
            };

            msg.AddTo(new EmailAddress(sendEmail.ToEmail));

            if (sendEmail.Attachment != null && sendEmail.Attachment.Length > 0)
            {
                var attachment = Convert.ToBase64String(sendEmail.Attachment);
                msg.AddAttachment(sendEmail.AttachmentName, attachment, "application/json");
            }

            var response = await client.SendEmailAsync(msg);
            if (response.IsSuccessStatusCode)
            {
                return "Success";
            }
            else
            {
                throw new Exception($"Error calling Sendgrid. Status code: {response.StatusCode}");
            }
        }
    }
}

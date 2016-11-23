using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace ChangKeTec.Wms.Utils
{
    public class MailHelper
    {
        private MailMessage mailMessage;

        private SmtpClient smtpClient;

        private string server;

        private string username;

        private string password;

        private bool enablessl;

        private bool credentials;

        private int port;

        public MailHelper(string To, string From, string Body, string Title, string Server, string Username, string Password, bool EnableSsl, int Port, bool Credentials, string AttachmentFile)
        {
            this.mailMessage = new MailMessage();
            this.mailMessage.To.Add(To);
            this.mailMessage.From = new MailAddress(From);
            this.mailMessage.Subject = Title;
            this.mailMessage.Body = Body;
            if (AttachmentFile != "")
            {
                Attachment attachment = new Attachment(AttachmentFile);
                this.mailMessage.Attachments.Add(attachment);
            }
            this.mailMessage.IsBodyHtml = true;
            this.mailMessage.BodyEncoding = Encoding.UTF8;
            this.mailMessage.Priority = MailPriority.Normal;
            this.server = Server;
            this.password = Password;
            this.username = Username;
            this.enablessl = EnableSsl;
            this.port = Port;
            this.credentials = Credentials;
        }

        public void Send()
        {
            if (this.mailMessage != null)
            {
                this.smtpClient = new SmtpClient();
                if (!this.credentials)
                {
                    this.smtpClient.Credentials = new NetworkCredential(this.username, this.password);
                }
                this.smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                this.smtpClient.Host = this.server;
                this.smtpClient.Port = this.port;
                this.smtpClient.EnableSsl = this.enablessl;
                this.smtpClient.Send(this.mailMessage);
            }
        }

        public void Attachments(string Path)
        {
            string[] pathArray = Path.Split(new char[]
            {
                ','
            });
            for (int i = 0; i < pathArray.Length; i++)
            {
                Attachment data = new Attachment(pathArray[i], "application/octet-stream");
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = File.GetCreationTime(pathArray[i]);
                disposition.ModificationDate = File.GetLastWriteTime(pathArray[i]);
                disposition.ReadDate = File.GetLastAccessTime(pathArray[i]);
                this.mailMessage.Attachments.Add(data);
            }
        }

        public void SendAsync(SendCompletedEventHandler completedMethod)
        {
            if (this.mailMessage != null)
            {
                this.smtpClient = new SmtpClient();
                this.smtpClient.Credentials = new NetworkCredential(this.mailMessage.From.Address, this.password);
                this.smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                this.smtpClient.Host = "smtp." + this.mailMessage.From.Host;
                this.smtpClient.SendCompleted += completedMethod.Invoke;
                this.smtpClient.SendAsync(this.mailMessage, this.mailMessage.Body);
            }
        }
    }
}

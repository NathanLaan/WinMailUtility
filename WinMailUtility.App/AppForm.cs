using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace WinMailUtility.App
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            int serverPort = 25;
            try {
                serverPort = int.Parse(this.serverPortTextbox.Text);
                SendMail(
                    this.serverNameTextbox.Text,
                    serverPort,
                    this.sourceEmailTextbox.Text,
                    this.destinationEmailTextbox.Text,
                    this.emailSubjectTextBox.Text,
                    this.emailMessageTextbox.Text);
            }
            catch {
                MessageBox.Show(this, "Please enter an Integer for the server port", "Server Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMail(string serverName, int serverPort, string sourceEmail, string destinationEmail, string subject, string message) {
            try {
                MailMessage mailMessage = new MailMessage(
                    sourceEmail,
                    destinationEmail,
                    subject,
                    message);
                SmtpClient smtpClient = new SmtpClient(serverName, serverPort);
                smtpClient.UseDefaultCredentials = true;
                Object asyncToken = new Object();
                smtpClient.SendAsync(mailMessage, asyncToken);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.ToString());
            }
        }

        /*
    Public Sub SendMail(ByVal message As String)
        Try

            '
            ' TODO: Load SOURCE from settings.
            '
            Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage("noreply@edmontonpolice.ca", Settings.SystemNotificationEmail)

            mailMessage.Subject = LogManager.LogName & ""
            mailMessage.Body = "<body>" & message & "</body>"
            mailMessage.IsBodyHtml = True
            Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(Settings.EmailNotificationServerName)
            smtpClient.UseDefaultCredentials = True
            smtpClient.Send(mailMessage)
        Catch ex As Exception
            LogError("Unable to send mail", ex)
        End Try
    End Sub
         * */
    }
}

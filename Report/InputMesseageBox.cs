using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;


namespace QuanLyCafe.Report
{
    public partial class InputMesseageBox : Form
    {
        private string fileName;
        private string subject;
        private string message;
        public InputMesseageBox(string subject, string message, string fileName)
        {
            this.subject = subject;
            this.message = message; 
            this.fileName = fileName;
            InitializeComponent();
            InitGUI();
        }

        public void InitGUI()
        {
            txtFrom.Text = "newkitblue01@gmail.com";
            txtTo.Text = "dangquan.x001@gmail.com";
            txtUsername.Text = "newkitblue01@gmail.com";
            txtPassword.Text = "12345!@zxc";
            txtSMTP.Text = "smtp.gmail.com";
            txtSubject.Text = subject;
            txtMessage.Text = message;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            // tạo một tin nhắn và thêm những thông tin cần thiết như: ai gửi, người nhận, tên tiêu đề, và có đôi lời gì cần nhắn nhủ
            MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text); //
            mail.IsBodyHtml = true;
            mail.Attachments.Add(new Attachment(fileName));
            //gửi tin nhắn
            //SmtpClient client = new SmtpClient(txtSMTP.Text);
            //client.Host = "smtp.gmail.com";
            //ta không dùng cái mặc định đâu, mà sẽ dùng cái của riêng mình
            //client.UseDefaultCredentials = false;
            //client.Port = 587; //vì sử dụng Gmail nên mình dùng port 587
            //                   // thêm vào credential vì SMTP server cần nó để biết được email + password của email đó mà bạn đang dùng
            //client.Credentials = new System.Net.NetworkCredential(txtUsername.Text, txtPassword.Text);
            //client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
            //client.Send(mail);
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
            }
        }
    }
}

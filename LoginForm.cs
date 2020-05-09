using System;
using PeerReviewSample.Processes;
using System.Windows.Forms;
using System.Threading;
namespace PeerReviewSample
{
    public partial class LoginForm : Form
    {
        Thread thread;
        int userId;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text;
            LogIn logIn = new LogIn(username, password);
            if (logIn.Authenticate())
            {
                //The credentials are correct
                userId = logIn.GetUserId();
              
                this.Close();
                thread = new Thread(OpenDashboard);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                //Wrong credentials
                //Send Messagebox
            }
            
        }
        private void OpenDashboard()
        {
            Application.Run(new Dashboard(userId));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "rakson";
            txtPassword.Text = "12345";
        }
    }
}

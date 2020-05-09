using System;
using PeerReviewSample.Processes;
using System.Threading;
using System.Windows.Forms;

namespace PeerReviewSample
{
    public partial class Dashboard : Form
    {
        private Thread thread;
        private int userId;
        private string fullName;
        public Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnMakeReviewRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            thread = new Thread(OpenReviewRequest);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenReviewRequest()
        {
            Application.Run(new MakeReviewRequest());
        }
        private void OpenLogin()
        {
            Application.Run(new LoginForm());
            
        }
        private void OpenRegister()
        {
            Application.Run(new RegistrationForm());
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            thread = new Thread(OpenRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            fullName=new LogIn(userId).GetFullName();
            this.Text = "Welcome, " + fullName;
        }

     
       

        private void btnReviewTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            thread = new Thread(OpenReviewTasks);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenReviewTasks( )
        {
            Application.Run(new ReviewTasks(userId));
        }
    }
}
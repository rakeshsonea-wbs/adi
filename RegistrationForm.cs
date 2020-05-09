using System;
using System.Data;
using System.Windows.Forms;
using PeerReviewSample.Utilities;
using PeerReviewSample.Processes;

namespace PeerReviewSample
{
    public partial class RegistrationForm : Form
    {
        Database db = new Database();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
          
            //Place all selected Specialisms into an array - specialismList

            int noOfSpecialisms = chkListSpecialisms.CheckedItems.Count;
            string[] specialismList = new string[noOfSpecialisms];
            int i = 0;
            foreach (var item in chkListSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialisms)
                {
                    specialismList[i] = item.ToString();
                }
                i++;
            }

            User newUser = new User();
            newUser.Firstname = txtFirstname.Text.Trim().ToLower();
            newUser.Surname = txtSurname.Text.Trim().ToLower();
            newUser.Username = txtUsername.Text.Trim().ToLower();
            newUser.Password = Encrypter.Encrypt(txtPassword.Text);
            newUser.SpecialismList = specialismList;

            Registration registration = new Registration();
            registration.Register(newUser);
        }
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }
    }
}

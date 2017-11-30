using EAS.Controller;
using EAS.UserInterface;
using System.Windows.Forms;

namespace EAS
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        LoginController LC;

        public Login()
        {
            InitializeComponent();

            LC = new LoginController(this);
        }


        private void SignUpLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().Show();
            Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignInB_Click(object sender, System.EventArgs e)
        {
            // fillup checking

            if (LC.Login(UserNameTB.Text, PasswordTB.Text))
            {
                if (LC.checkType(UserNameTB.Text))
                {
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    new AdminInterface().Show();
                }
                else
                {
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    new PatientInterface().Show();
                }
            }
            else {
                MessageBox.Show("Incorrect Information");
            }
        }
    }




}

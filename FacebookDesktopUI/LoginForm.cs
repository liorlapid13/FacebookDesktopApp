using System;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class LoginForm : Form
    {
        private readonly LoginPage r_LoginPage;

        public LoginForm()
        {
            InitializeComponent();
            r_LoginPage = new LoginPage();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_LoginPage.Login();
                new MainForm(this).ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace CCPTimer
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && passwordTextBox.Text != "")
            {
                Main.IsLoggedIn = true;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1.PerformClick();
            }
        }
    }
}

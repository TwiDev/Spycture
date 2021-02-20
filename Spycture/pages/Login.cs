using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spycture.pages
{
    public partial class Login : Form
    {

        public static bool isLogin = false;

        public Login()
        {
            InitializeComponent();

            this.ActiveControl = send;
            send.Focus();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            String id = this.box_id.Text;
            String password = this.box_password.Text;

            if (password == "" && id == "")
            {
                isLogin = true;
                this.Close();
            }
            else
            {
                this.subtitle.Text = "    Erreur identifiant ou mot de passe incorrecte";
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin) return;
            System.Windows.Forms.Application.Exit();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.Handled = true;
                e.SuppressKeyPress = true;

                this.send.PerformClick();
            }
        }
    }
}

using Spycture.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spycture
{
    public partial class Main : Form
    {

        public static Login dashboard;

        public static Main instance;

        public Main()
        {
            InitializeComponent();

            instance = this;
            dashboard = new Login();

            using (Login login = new Login())
            {
                login.ShowDialog();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

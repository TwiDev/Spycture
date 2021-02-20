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

        public Main()
        {
            InitializeComponent();

            dashboard = new Login();

            using (Login login = new Login())
            {
                login.ShowDialog();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}

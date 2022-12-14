using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_vxjq3v
{
    public partial class FormSzűrés : Form
    {
        public FormSzűrés()
        {
            InitializeComponent();
        }

        private void buttonÉv_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlÉv userControlÉv = new();
            panel1.Controls.Add(userControlÉv);
            userControlÉv.Dock = DockStyle.Fill;
        }

        private void buttonSebesség_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlSebesség userControlSebesség = new();
            panel1.Controls.Add(userControlSebesség);
            userControlSebesség.Dock = DockStyle.Fill;
        }

        private void buttonGyorsulás_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlGyorsulás userControlGyorsulás = new();
            panel1.Controls.Add(userControlGyorsulás);
            userControlGyorsulás.Dock = DockStyle.Fill;
        }
    }
}

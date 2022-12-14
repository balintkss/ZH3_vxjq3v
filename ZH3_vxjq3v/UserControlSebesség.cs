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
    public partial class UserControlSebesség : UserControl
    {
        Models.carsContext context = new();
        public UserControlSebesség()
        {
            InitializeComponent();
            carsBindingSource.DataSource = context.Cars.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            int maxseb = Convert.ToInt32(textBox1.Text);
            var szűr = from x in context.Cars
                       where x.MaxSpeed >= maxseb
                       select x;
            dataGridView1.DataSource = szűr.ToList();
        }
    }
}

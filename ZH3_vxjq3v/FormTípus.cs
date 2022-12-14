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
    
    public partial class FormTípus : Form
    {
        Models.carsContext context = new Models.carsContext();
        public FormTípus()
        {
            InitializeComponent();
            Betölt();
        }
        void Mentés()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Betölt()
        {
            var típus = from x in context.Body
                        select x.BodyType;
            listBox1.DisplayMember = "Body";
            listBox1.DataSource = típus.ToList();
        }

        private void buttonMégse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Models.Body newbody = new Models.Body();
            newbody.BodyType = textBoxTípus.Text;
            context.Add(newbody);
            Mentés();
            Betölt();
        }
    }
}

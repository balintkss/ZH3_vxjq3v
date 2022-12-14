using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_vxjq3v
{
    public partial class FormMódosít : Form
    {
        Models.carsContext context = new();
        public FormMódosít()
        {
            InitializeComponent();
            Frissít();
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
        void Frissít()
        {
            carsBindingSource.DataSource = context.Cars.ToList();
            engineBindingSource.DataSource = context.Engine.ToList();
            bodyBindingSource.DataSource = context.Body.ToList();
        }
        private void buttonTöröl_Click_1(object sender, EventArgs e)
        {
            dynamic elem = dataGridView1.CurrentRow.DataBoundItem;
            int index = elem.Id;
            var törlés = from x in context.Cars
                         where x.Id == index
                         select x;
            DialogResult megerősít = MessageBox.Show("Véglegesen törlöd a sort?", "Törlés", MessageBoxButtons.YesNo);
            if (megerősít == DialogResult.Yes)
            {
                context.Cars.Remove(törlés.FirstOrDefault());
            }
            Mentés();
            Frissít();
        }

        

        private void buttonHozzáad_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                Models.Cars newcar = new();
                newcar.BodyTypeId = 1;
                newcar.EngineId = 1;
                newcar.Year = int.Parse(textBoxÉv.Text);
                newcar.Model = textBoxTípus.Text;
                if (textBoxVégsebesség.Text is not null && textBox0100.Text is not null)
                {
                    newcar.Acceleration = int.Parse(textBox0100.Text);
                    newcar.MaxSpeed = int.Parse(textBoxVégsebesség.Text);
                }
                if (radioButton4ülés.Checked == true)
                {
                    newcar.NumberSeater = 4;
                }
                else if (radioButton5ülés.Checked == true)
                {
                    newcar.NumberSeater = 5;
                }
                else
                {
                    newcar.NumberSeater = 0;
                }
                context.Add(newcar);
                Mentés();
                Frissít();
            }
        }

        private void buttonTípus_Click(object sender, EventArgs e)
        {
            FormTípus formTípus = new();
            formTípus.ShowDialog();
        }

        private void textBoxÉv_Validating_1(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[1-2]{1}[0-9]{3}");
            if (!regex.IsMatch(textBoxÉv.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxÉv, "Az évet 1000-2999-ig kell megadni");
            }
        }

        private void textBoxÉv_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxÉv, "");
        }

        private void textBoxTípus_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTípus, "");
        }

        private void textBoxTípus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTípus.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTípus, "Nem lehet űres");
            }
        }
    }


}

namespace ZH3_vxjq3v
{
    public partial class Form1 : Form
    {
        Models.carsContext context = new();

        public Form1()
        {
            InitializeComponent();
            Keres();
        }
        void Keres()
        {
            int darab = (from x in context.Cars
                         select x).Count();
            labelCount.Text = darab.ToString();
            double átlag = (from x in context.Cars
                            select x.Year).Average();
            labelAvg.Text = Math.Round(átlag, 2).ToString();
        }

        private void buttonSzûrés_Click(object sender, EventArgs e)
        {
            FormSzûrés formSzûrés = new();
            formSzûrés.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMódosít formMódosít = new();
            formMódosít.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos be akarod zárni?","Bezár",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
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
            double �tlag = (from x in context.Cars
                            select x.Year).Average();
            labelAvg.Text = Math.Round(�tlag, 2).ToString();
        }

        private void buttonSz�r�s_Click(object sender, EventArgs e)
        {
            FormSz�r�s formSz�r�s = new();
            formSz�r�s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormM�dos�t formM�dos�t = new();
            formM�dos�t.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos be akarod z�rni?","Bez�r",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
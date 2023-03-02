namespace SR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f;
            a = (double)numericUpDown1.Value;
            b = (double)numericUpDown2.Value;
            c = (double)numericUpDown3.Value;
            d = (double)numericUpDown4.Value;
            f = (double)numericUpDown5.Value;
            double[] ocenki = { a, b, c, d, f };
            label3.Text = "Лучший результат " + ocenki.Max();
            label4.Text = "Средний результат " + (a + b + c + d + f)/5;
            label5.Text = "Худший результат " + ocenki.Min();
            //Подгорбунский Виктор
        }
    }
}
namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ortalama;
            String ad, soyad;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            not1 = Convert.ToInt32(textBox3.Text);
            not2 = Convert.ToInt32(textBox4.Text);
            not3 = Convert.ToInt32(textBox5.Text);
            ortalama = (not1 + not2 + not3) / 3;

            listBox1.Items.Add(ad + " " + soyad + " " + " " + ortalama);




        }
    }
}
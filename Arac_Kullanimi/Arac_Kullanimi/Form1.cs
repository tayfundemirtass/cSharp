namespace Arac_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Selamlar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Baran";
            label7.Text = "Þamlý";
            label8.Text = "Yazýlým";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Baran";

            label9.Text = textBox1.Text;
        }
    }
}

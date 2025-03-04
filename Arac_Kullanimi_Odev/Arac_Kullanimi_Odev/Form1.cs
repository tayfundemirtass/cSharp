namespace Arac_Kullanimi_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblname.Text = txtad.Text;
            lblsoyad.Text = txtsoyad.Text;
            lblmeslek.Text = txtmeslek.Text;

            lblname.Visible = true;
            lblsoyad.Visible = true;
            lblmeslek.Visible = true;
        }
    }
}

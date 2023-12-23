namespace TranslatorCC
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();  
        Form4 form4 = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
            form2.Owner = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
            form3.Owner = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
            form4.Owner = this; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorCC
{
    public partial class Form2 : Form
    {
        _10CC_to_xCC tr = new _10CC_to_xCC();
        Remover_Zero rz = new Remover_Zero();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_Closed(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Chislo.Text == "" || CC.Text == "")
            {
                Answer.Text = "Неверный ввод";
            }
            else if (Kolvo.Text == "")
            {
                Kolvo.Text = "0";
                rz.RemoveZero(Chislo.Text);
                Answer.Text = tr.Tr(Chislo.Text, int.Parse(Kolvo.Text), int.Parse(CC.Text));
            }
            else 
            {
                rz.RemoveZero(Chislo.Text);
                Answer.Text = tr.Tr(Chislo.Text, int.Parse(Kolvo.Text), int.Parse(CC.Text));
            }
        }
    }
}

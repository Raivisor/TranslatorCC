using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorCC
{
    public partial class Form3 : Form
    {
        xCC_to_10CC tr = new xCC_to_10CC();
        Remover_Zero rz = new Remover_Zero();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void Form2_Closed(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Chislo.Text == "" || CC.Text == "")
            {
                Answer.Text = "Неверный ввод";
            }
            else if (int.Parse(CC.Text) <= 1)
            {
                Answer.Text = "Минимальная СС - 2";
            }
            else 
            {
                rz.RemoveZero(Chislo.Text);
                Answer.Text = tr.Tr(Chislo.Text, int.Parse(CC.Text));
            }
        }
    }
}

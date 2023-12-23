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
    public partial class Form4 : Form
    {
        Remover_Zero rz = new Remover_Zero();
        _10CC_to_xCC trx = new _10CC_to_xCC();
        xCC_to_10CC tr10 = new xCC_to_10CC();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void Form4_Closed(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Chislo.Text == "" || CC_default.Text == "" || CC_to_tr.Text == "")
            {
                Answer.Text = "Неправильный ввод";
            }
            else 
            {
                rz.RemoveZero(Chislo.Text);
                string s = tr10.Tr(Chislo.Text, int.Parse(CC_default.Text));
                if (Kolvo.Text == "")
                {
                    Kolvo.Text = "0";
                    Answer.Text = trx.Tr(s, int.Parse(Kolvo.Text), int.Parse(CC_to_tr.Text));
                }
                else
                {
                    Answer.Text = trx.Tr(s, int.Parse(Kolvo.Text), int.Parse(CC_to_tr.Text));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.UNİTE_UYGULAMA_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SAYİ1, KARESİ;
            try
            {
                SAYİ1 = Convert.ToInt16(textBox1.Text);
                KARESİ = SAYİ1 * SAYİ1;
                MessageBox.Show("sayının karesi=    " + KARESİ);
            }
            catch
            {
                MessageBox.Show("hatatlı   ");
            }
         
        }
    }
}

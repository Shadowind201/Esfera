using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int raio = Convert.ToInt32(textBox1.Text);

            double volume = (4 * 3.14 * raio * raio * raio) / 3;

            resultado.Text = ("= " + volume);
        }
    }
}

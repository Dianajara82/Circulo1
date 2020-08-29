using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double circunferencia;
        double radio;
        double area;

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(textBox1.Text);
            circunferencia = 2 * Math.PI * radio;
            label1.Text = Convert.ToString("La circunferencia del circulo es:" + circunferencia);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(textBox1.Text);
            area = Math.PI * radio * radio;
            label1.Text = Convert.ToString("El area del circulo es:" + area);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

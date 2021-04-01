using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            float lado;
            float area;
            float perimetro;

            //captura de datos
            lado = float.Parse(txtlado.Text);

            //proceso
            area = lado * lado;
            perimetro = lado * 4;
            //salida
            txtarea.Text = area.ToString();
            txtperimetro.Text = perimetro.ToString();
        }
    }
}

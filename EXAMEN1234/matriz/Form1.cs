using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{
   
    public partial class Form1 : Form
    {
        Matriz m1, m2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Matriz();
            m2 = new Matriz();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = m1.descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = m1.descargar();
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m1.CalcularElementosDistintosPorFila();
            //textBox6.Text = m1.descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}

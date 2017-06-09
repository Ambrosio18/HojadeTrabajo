using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HojadeTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                double suma = Math.Pow(x, 2) + Math.Pow(y, 2);
                double hipotenusa = Math.Sqrt(suma);

                MessageBox.Show("la hipotenusa es: "+ hipotenusa);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ingresar datos validos");
            }
            

        }
    }
}

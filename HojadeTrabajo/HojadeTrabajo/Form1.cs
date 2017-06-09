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

        private void button2_Click(object sender, EventArgs e)
        {
           Boolean a1, e1, o1, i1, u1;
            a1 = prueba('a');
            e1 = prueba('e');
            i1 = prueba('i');
            o1 = prueba('o');
            u1 = prueba('u');
            if(a1 & e1 & o1 & i1 & u1 ==true){
                MessageBox.Show("cumple");
            }else
	        {
                MessageBox.Show("No Cumple");
	        }
           
        }

        public Boolean prueba(char x)
        {
            String y = textBox1.Text.ToLower();
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == x)
                {
                    return true;
                }

            }
            return false;
        

            
        }
    }
}

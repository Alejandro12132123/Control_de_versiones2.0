using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_versiones2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener los nombres y apellidos de cliente y los meses a pagar sobre curso de automotores o motocicletas

            string Nombre = textNombre.Text;
            string Apellido = textApellido.Text;
            string Curso = comboBox1.Text;
            double Meses = (int)numericUpDown1.Value;

            //Calcular los meses y el descuento 

            double descuento = 0;
            if (Meses >= 2 && Meses <= 3)
            {
                descuento = 0.10;

            }
            else if (Meses >= 4 && Meses <= 6)
            {
                descuento = 0.15;
            }
            else if (Meses >= 7 && Meses <= 8)
            {
                descuento = 0.20;
            }
            else if (Meses >= 9 && Meses <= 10)
            {
                descuento = 0.25;
            }
            else if (Meses >= 11 && Meses <= 11)
            {
                descuento = 0.30;
            }
            else if (Meses >= 12 && Meses <= 12)
            {
                descuento = 0.45;
            }
            else
            { MessageBox.Show("No a ingresado cuantos meses desea pagar"); }

            //Calcular lo que pagara el cliente de acuerdo a cuantos meses

            double Total = Meses * 30 - descuento * Meses * 30;

            // Mostrar resultado 

            MessageBox.Show("Nombres: " + Nombre + "\nApellidos: " + Apellido + "\nCurso que tomo : " + Curso + " \nMeses: " + Meses + "\nDescuento: " + descuento + "\nTotal a pagar:  " + Total);


        }

      
    }
}

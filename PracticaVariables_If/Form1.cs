using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaVariables_If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbImprimir_Click(object sender, EventArgs e)
        {
            decimal Nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal Nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal Nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal Nota4 = Convert.ToDecimal(txtNota4.Text);

            decimal NumMayor = Nota1;
            if (NumMayor < Nota2)
            {
                NumMayor = Nota2;
            }
            if (NumMayor < Nota3)
            {
                NumMayor = Nota3;
            }
            if (NumMayor < Nota4)
            {
                NumMayor = Nota4;
            }

            decimal suma = Nota1 + Nota2 + Nota3 + Nota4;
            decimal Promedio = suma / 4;

            MessageBox.Show("La nota mayor es: " + NumMayor);
            MessageBox.Show("El promedio de notas es: " + Promedio);

            if (Promedio >= 9)
            {
                MessageBox.Show("EXCELENTE!");
            }
            else
            {
                if (Promedio >= 7)
                {
                    MessageBox.Show("MUY BIEN!");
                }
                else
                {
                    if (Promedio >= 4)
                    {
                        MessageBox.Show("Regular");
                    }
                    else
                    {
                        MessageBox.Show("En proceso de aprendizaje");
                    }
                }
            }
        }
    }
}

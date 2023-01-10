using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsClinica.Models;//agregar namespace

namespace WindowsClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            //declarar y crear una instancia de medico
            Medico medico = new Medico();

            //SER Escribir las propiedades
            medico.Nombre = "Juan";
            medico.Apellido = "Perez";
            medico.Matricula = 123456;

            //Get leer las propiedades
            MessageBox.Show(medico.Nombre + " " + medico.Apellido + " " + medico.Matricula.ToString());
        }
    }
}

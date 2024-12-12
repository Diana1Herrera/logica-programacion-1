using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3DianaCarolinaHerrera
{
    public partial class Form1 : Form
    {
        private const string clave = "123";
        private ErrorProvider error;

        public Form1()
        { InitializeComponent();
            error = new ErrorProvider();
            fmrEstructuraDatos estructuraDatos = new fmrEstructuraDatos();
            estructuraDatos.Show();
            //this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Deshabilitar los campos
            txtClave.Enabled = false;
            btnIngresar.Enabled = false;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("o\tInterfaz gráfica interactiva para entrada de datos y operaciones" +
                " \n o\tMecanismos de validación para los datos ingresados. \n o\tCálculos dinámicos como promedios y totales.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            //Validacion de contraseña
            string laClave = "";
            laClave = this.txtClave.Text.Trim();
            if (laClave.Equals(""))
            {
                this.error.SetError(this.txtClave, "Ingresa la clave correctamente.");
                this.txtClave.Focus();
            }
            else
            {
                if (!laClave.Equals(clave))
                {
                    this.error.SetError(this.txtClave, "Contraseña invalida.");
                    this.txtClave.Focus();
                }
                else
                {
                    this.error.SetError(this.txtClave, null);
                    //Abrir el formulario
                    fmrEstructuraDatos estructuraDatos = new fmrEstructuraDatos();
                    estructuraDatos.Show();
                    this.Hide();
                }
            }
        }

        private void ItemInicio_Click(object sender, EventArgs e)
        {
            txtClave.Enabled = true;
            btnIngresar.Enabled = true;
            txtClave.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

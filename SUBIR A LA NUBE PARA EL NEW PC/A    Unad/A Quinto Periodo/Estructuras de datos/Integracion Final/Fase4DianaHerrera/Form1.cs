using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4DianaHerrera
{
    public partial class Form1 : Form
    {
        private const string clave = "UNAD";
        private ErrorProvider error;
        public Form1()
        {
           //InitializeComponent();
            this.Load += new EventHandler(Form_Load);
            error = new ErrorProvider();
            fmrArbol arbolForm = new fmrArbol();
            arbolForm.Show();
            this.Hide();
        }

        private void ActualizarFecha()
        {
          //  lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM yyyy");
        }
        private void Form_Load(object sender, EventArgs e)
        {

            ActualizarFecha();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string laClave = "";
            laClave = this.txtContrasena.Text.Trim();
            if (laClave.Equals(""))
            {
                this.error.SetError(this.txtContrasena, "Ingresa la clave correctamente.");
                this.txtContrasena.Focus();
            }
            if (!laClave.Equals(clave))
            {
                this.error.SetError(this.txtContrasena, "Contraseña invalida.");
                this.txtContrasena.Focus();
            }
            else
            {
                this.error.SetError(this.txtContrasena, null);
                // Crear una instancia del formulario arbolBinario y mostrarlo
                fmrArbol arbolForm = new fmrArbol();
                arbolForm.Show();
                this.Hide(); // Oculta el formulario de inicio si no necesitas que siga visible
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
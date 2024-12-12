using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2DianaHerrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           //InitializeComponent();
            this.Hide();
            IngresoDeDatos formulario = new IngresoDeDatos();
            formulario.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e) // Metodo
        {
            if(txtPassword.Text != "123")
            {
                MessageBox.Show("Contraseña incorrecta");
                txtPassword.Text = string.Empty;
                txtPassword.Focus();
                
            }
            else
            { //abrir formulario IngresoDatos
                this.Hide();
                IngresoDeDatos formulario = new IngresoDeDatos();
                formulario.ShowDialog();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

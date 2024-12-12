using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2DianaHerrera
{
    public partial class IngresoDeDatos : Form
    {
        GestionEstudiantes datoEstudiante = new GestionEstudiantes(); // instancia 

        Dictionary<string, decimal> almacenar = new Dictionary<string, decimal>
{
          { "Guitarra", 80000m },
          { "Piano", 100000m },
          { "Bateria", 85000m },
          { "Canto", 95000m },
          { "Violin", 90000m }
};
        
        public IngresoDeDatos() // metodo
        {
            InitializeComponent();
        }
        // Evento que se ejecuta cuando se selecciona un instrumento en el ComboBox
        private void cmbInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string instrumentoSeleccionado = cmbInstrumento.SelectedItem.ToString();

            // Verificar si el instrumento está en el diccionario 'almacenar'
            if (almacenar.ContainsKey(instrumentoSeleccionado))
            {
                // Mostrar el precio en el TextBox
                txtCostoClase.Text = almacenar[instrumentoSeleccionado].ToString("C");
            }
            else
            {
                // Si no hay un precio
                txtCostoClase.Text = "No encontrado";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e) // metodo
        {
            // Validacion de errores
            bool error = false;
            //Si algun campo esta vacio
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbInstrumento.SelectedIndex == -1 ||
                 string.IsNullOrWhiteSpace(txtNumeroClase.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hay campos vacíos
            } 
            // validar los caracteres
            foreach (char caracter in txtNumeroClase.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtNumeroClase, "No se admite caracteres");
            }
            else errorProvider1.Clear();

            foreach (char caracter in txtName.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtName, "No se admite numeros");
            }
            else errorProvider1.Clear();

            foreach (char caracter in txtIdentificacion.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtIdentificacion, "No se admite caracteres");
            }
            else errorProvider1.Clear();
            if (radioButtonFemenino.Checked == false && radioButtonMasculi.Checked == false)
            {
                // Mostrar un mensaje indicando que debe seleccionar un género
                MessageBox.Show("Debe seleccionar un género antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar los datos de los estudiantes

            datoEstudiante.Id = int.Parse(txtIdentificacion.Text);
            datoEstudiante.Nombre = txtName.Text;
            datoEstudiante.Instrumento = cmbInstrumento.SelectedItem.ToString(); ;
            datoEstudiante.NumeroClases = int.Parse(txtNumeroClase.Text);

            if (radioButtonFemenino.Checked)
            {
                datoEstudiante.Genero = "Femenino";
            }
            else if (radioButtonMasculi.Checked)
            {
                datoEstudiante.Genero = "Masculino";
            }
            switch (datoEstudiante.Instrumento.ToLower())
            {
                case "piano":
                    datoEstudiante.CostoPorClase = 100000;
                    break;
                case "guitarra":
                    datoEstudiante.CostoPorClase = 80000;
                    break;
                case "violin":
                    datoEstudiante.CostoPorClase = 90000;
                    break;
                case "bateria":
                    datoEstudiante.CostoPorClase = 85000;
                    break;
                case "canto":
                    datoEstudiante.CostoPorClase = 95000;
                    break;
                default:
                    datoEstudiante.CostoPorClase = 0;
                    break;
            }

            MessageBox.Show("Se guardó con exito.");

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in txtName.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtName, "No se admite numeros");
            }
            else errorProvider1.Clear();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            // validar errores
            bool error = false;
            foreach (char caracter in txtIdentificacion.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtIdentificacion, "No se admite caracteres");
            }
            else errorProvider1.Clear();
        }

        private void txtNumeroClase_TextChanged(object sender, EventArgs e)
        {
            // validar errores
            bool error = false;
            foreach (char caracter in txtNumeroClase.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtNumeroClase, "No se admite caracteres");
            }
            else errorProvider1.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo
            DialogResult resultado = MessageBox.Show("Quiere salir de la aplicación?",
             "Confirmar salida",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Salir de la aplicación
            }
            else
            {
                // El usuario se queda en el formulario
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e) // metodo
        {
            // validar errores

            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
               string.IsNullOrWhiteSpace(txtName.Text) ||
               cmbInstrumento.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtNumeroClase.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si hay campos vacíos
            }
            
                if (radioButtonFemenino.Checked == false && radioButtonMasculi.Checked == false)
            {
                // Mostrar un mensaje indicando que debe seleccionar un género
                MessageBox.Show("Debe seleccionar un género antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            // mostrar los datos
                datoEstudiante.Id = int.Parse(txtIdentificacion.Text);
                datoEstudiante.Nombre = txtName.Text;
                datoEstudiante.Instrumento = cmbInstrumento.SelectedItem.ToString(); ;
                datoEstudiante.NumeroClases = int.Parse(txtNumeroClase.Text);

            if (radioButtonFemenino.Checked)
            {
                datoEstudiante.Genero = "Femenino";
            }
            else if (radioButtonMasculi.Checked)
            {
                datoEstudiante.Genero = "Masculino";
            }
            switch (datoEstudiante.Instrumento.ToLower())
            {
                case "piano":
                    datoEstudiante.CostoPorClase = 100000;
                    break;
                case "guitarra":
                    datoEstudiante.CostoPorClase = 80000;
                    break;
                case "violin":
                    datoEstudiante.CostoPorClase = 90000;
                    break;
                case "bateria":
                    datoEstudiante.CostoPorClase = 85000;
                    break;
                case "canto":
                    datoEstudiante.CostoPorClase = 95000;
                    break;
                default:
                    datoEstudiante.CostoPorClase = 0;
                    break;
            }
            Reporte resultado = new Reporte(datoEstudiante); // instancia del formulario reporte
            resultado.Show();
            Hide();

        }

      
    }

    }


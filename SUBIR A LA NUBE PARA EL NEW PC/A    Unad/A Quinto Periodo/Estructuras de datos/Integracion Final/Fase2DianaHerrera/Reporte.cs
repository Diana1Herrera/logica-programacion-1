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
    public partial class Reporte : Form
    {
        private GestionEstudiantes datoEstudiantes;
        public Reporte(GestionEstudiantes datoEstudiantes)
        {
            InitializeComponent();
            this.datoEstudiantes = datoEstudiantes;
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            lblNombreEstudiante.Text = datoEstudiantes.Nombre;
            lblIdentificacion.Text = datoEstudiantes.Id.ToString();
             lblInstrumento.Text = datoEstudiantes.Instrumento;
            lblNumeroClases.Text = datoEstudiantes.NumeroClases.ToString();
            lblGenero.Text = datoEstudiantes.Genero;


            double costoClase = datoEstudiantes.CostoPorClase;
            int numeroClase = datoEstudiantes.NumeroClases;

            lblCostoPorClase.Text = costoClase.ToString("C");
            lblCostoTotal.Text = datoEstudiantes.costoCurso(numeroClase, costoClase).ToString("C");

            DateTime fechaRegistro = DateTime.Now;
            lblFecha.Text = "Fecha de registro: " + fechaRegistro.ToString("dd/MM/yyyy HH:mm");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            IngresoDeDatos datos = new IngresoDeDatos(); // instancia del formulario  IngresoDeDatos
            datos.Show();
            Hide();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}

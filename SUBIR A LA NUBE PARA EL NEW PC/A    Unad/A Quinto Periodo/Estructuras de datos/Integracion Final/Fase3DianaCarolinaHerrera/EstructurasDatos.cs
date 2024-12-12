using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fase3DianaCarolinaHerrera
{
    public partial class fmrEstructuraDatos : Form
    {
        private string identificacion;
        private string nombre;
        private string reporteDatos;
        private string copago;
        private string estrato;
        private string tipoEstructura;
        private string tipoId;
        private string fecha;
        private string edad;
        private int reportePila;
        private int reporteCola;
        private int reporteLista;
        private int sumaEdadesLista = 0;

        Stack<EstructuraDatosUsuario> pilaUsuario = new Stack<EstructuraDatosUsuario>();
        Queue<EstructuraDatosUsuario> colaUsuario = new Queue<EstructuraDatosUsuario>();
        List<EstructuraDatosUsuario> listaUsuario = new List<EstructuraDatosUsuario>();

        public fmrEstructuraDatos()
        {
            InitializeComponent();
            this.reporteCola = 0;
            this.reportePila = 0;
            this.reporteLista = 0;
            this.btnReporteCola.Enabled = false;
            this.btnReportePila.Enabled = false;
            this.btnReporteLista.Enabled = false;
            this.btnEliminarCola.Enabled = false;
            this.btnEliminarPila.Enabled = false;
            this.btnEliminarLista.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmación",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        } 
        private void IniciarObjetosFmr()
        {
            this.txtIdentificacion.Text = "";
            this.txtNombre.Text = "";
            this.txtReporteDatos.Text = "";
            this.txtCopago.Text = "";
            this.cmbEstrato.Text = "";
            this.cmbTipoEstructura.Text = "";
            this.cmbTipoId.Text = "";
            this.dateFecha.Value = DateTime.Now;
            this.rdExamen.Checked = false;
            this.rdGeneral.Checked = false;

            this.cmbTipoEstructura.Items.Clear();
            this.cmbEstrato.Items.Clear();
            this.cmbTipoId.Items.Clear();
        }
        private void LimpiarFmr() // metodo limpia
        {
            this.txtIdentificacion.Text = "";
            this.txtNombre.Text = "";
            this.txtReporteDatos.Text = "";
            this.txtCopago.Text = "";
            this.cmbEstrato.Text = "";
            this.txtEdad.Text = "";
            this.cmbTipoEstructura.Text = "";
            this.cmbTipoId.Text = "";
            this.dateFecha.Value = DateTime.Now;
            this.rdExamen.Checked = false;
            this.rdGeneral.Checked = false;
            this.cmbEstrato.SelectedIndex = -1;
            this.cmbTipoEstructura.SelectedIndex = -1;
            this.cmbTipoId.SelectedIndex = -1;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        { //validaciones
            bool error = false; //declara una variable booleana

            foreach (char caracter in txtNombre.Text) // recorre cada carácter de la propiedad Text
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtNombre, "No se admite numeros");
            }
            else errorProvider1.Clear();
        }
        public int calcularValor() // metodo
        {
            int valor = 0; // inicializa variable

            if (rdGeneral.Checked)
            {
                switch (cmbEstrato.Text)
                {
                    case "1": valor = 0; break;
                    case "2": valor = 0; break;
                    case "3": valor = 10000; break;
                    case "4": valor = 15000; break;
                    case "5": valor = 20000; break;
                    case "6": valor = 30000; break;
                }
            }
            if (rdExamen.Checked)
            {
                switch (cmbEstrato.Text)
                {
                    case "1": valor = 0; break;
                    case "2": valor = 0; break;
                    case "3": valor = 0; break;
                    case "4": valor = 5000; break;
                    case "5": valor = 10000; break;
                    case "6": valor = 20000; break;
                }
            }
            
            return valor;
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {   //validaciones
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
        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
          
            bool error = false;
            foreach (char caracter in txtEdad.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtEdad, "No se admite caracteres");
            }
            else errorProvider1.Clear();
        }
        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            int copago = calcularValor();
            txtCopago.Text = copago.ToString("C"); 
        }
        private void rdGeneral_CheckedChanged(object sender, EventArgs e)
        {
            int copago = calcularValor();
            txtCopago.Text = copago.ToString("C"); 
        }
        private void rdExamen_CheckedChanged(object sender, EventArgs e)
        {
            int copago = calcularValor();
            txtCopago.Text = copago.ToString("C"); 
        }


        //metodo para validar si el usuario ya esta registrado 
  
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
                  //Validar si hay espacios en blanco 
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                  string.IsNullOrWhiteSpace(txtNombre.Text) ||
                  cmbTipoEstructura.SelectedIndex == -1 || cmbTipoId.SelectedIndex == -1 || cmbEstrato.SelectedIndex == -1 ||
                  string.IsNullOrWhiteSpace(txtEdad.Text) || !rdGeneral.Checked && !rdExamen.Checked)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            EstructuraDatosUsuario miEstructura = new EstructuraDatosUsuario();//instancia
            miEstructura.identificacion = txtIdentificacion.Text;
            miEstructura.nombre = txtNombre.Text;
            miEstructura.reporteDatos= txtReporteDatos.Text;
            miEstructura.copago= txtCopago.Text;
            miEstructura.estrato = cmbEstrato.SelectedItem.ToString(); 
            miEstructura.edad = txtEdad.Text;
            miEstructura.tipoId = cmbTipoId.SelectedItem.ToString(); 
            miEstructura.tipoEstructura = cmbTipoEstructura.SelectedItem.ToString();
            miEstructura.fecha = dateFecha.Value;
            miEstructura.copago = calcularValor().ToString();

           txtCopago.Text = miEstructura.copago;
            txtReporteDatos.Text = miEstructura.reporteDatos;

            if (miEstructura.tipoEstructura.Equals("Pila"))
            {

               
                this.reportePila += int.Parse(miEstructura.copago);
               
                this.pilaUsuario.Push(miEstructura); // agrega miEstructura a la pila
                dgPila.DataSource = null;
                dgPila.DataSource = this.pilaUsuario.ToArray(); //convierte la pila a un arreglo
                this.tab.SelectedIndex = 0; // cambia  ala pestaña pila que es el 0

              //  txtReporteDatos.Text = "$" + this.reportePila.ToString();
                MessageBox.Show("Se agrego a la pila correctamente");
              
                this.btnReportePila.Enabled = true; //se habilitan los botones
                this.btnEliminarPila.Enabled = true;
            }
            else if (miEstructura.tipoEstructura.Equals("Cola"))
            {
                this.reporteCola = this.reporteCola + 1; // incrementa en 1 para dar la cantidad de elementos en la cola

                this.colaUsuario.Enqueue(miEstructura); //se agrega miEstructura a cola
                dgCola.DataSource = null;
                dgCola.DataSource = this.colaUsuario.ToArray(); //elementos actuales de la cola
                this.tab.SelectedIndex = 1; 

              // txtReporteDatos.Text = this.reporteCola.ToString();
                MessageBox.Show("Se agrego a la cola correctamente");
                this.btnReporteCola.Enabled = true;
                this.btnEliminarCola.Enabled = true;
              
            }
           else if (miEstructura.tipoEstructura.Equals("Lista"))
            {
                this.listaUsuario.Add(miEstructura); //Se usa ADD
                this.sumaEdadesLista += int.Parse(miEstructura.edad);// se hace el promedio de edades
                double promedioEdad = (double)this.sumaEdadesLista / this.listaUsuario.Count;

                dgLista.DataSource = null;
                dgLista.DataSource = this.listaUsuario.ToArray();
                this.tab.SelectedIndex = 2;
                MessageBox.Show("Se agrego a la lista correctamente");
              

                this.btnReporteLista.Enabled = true;
                this.btnEliminarLista.Enabled = true;
            }
          
        }

        private void btnReportePila_Click(object sender, EventArgs e)
        {
           
            txtReporteDatos.Text = "$" + this.reportePila.ToString();
        }
       
        private void btnReporteCola_Click(object sender, EventArgs e)
        {
           
            txtReporteDatos.Text =  this.reporteCola.ToString();
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            if (this.listaUsuario.Count > 0)
            {
                // Calcula promedio
                double promedioEdades = (double)this.sumaEdadesLista / this.listaUsuario.Count;

                txtReporteDatos.Text = promedioEdades.ToString("F2");
            }
            else
            {
                MessageBox.Show("No hay registros ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            this.txtIdentificacion.Text = "";
            this.txtNombre.Text = "";
            this.txtReporteDatos.Text = "";
            this.txtCopago.Text = "";
            this.txtEdad.Text = "";
            this.cmbEstrato.SelectedIndex = -1;
            this.cmbTipoEstructura.SelectedIndex = -1;
            this.cmbTipoId.SelectedIndex = -1;
            this.dateFecha.Value = DateTime.Now;

            // Desmarcar los RadioButtons
            this.rdGeneral.Checked = false;
            this.rdExamen.Checked = false;

            // Si tienes algún error provider, también puedes limpiarlo
            errorProvider1.Clear();
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (this.pilaUsuario.Count >0) {
                if (MessageBox.Show("Desea eliminar el ultimo registro de la pila? ", "Confirmacion", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario miEstructura = new EstructuraDatosUsuario();
                    miEstructura = this.pilaUsuario.Pop();
                    this.reportePila -= int.Parse(miEstructura.copago);
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.pilaUsuario.ToArray();

                    // Recalcular la suma de los copagos
                    int sumaCopagos = this.pilaUsuario.Sum(usuario => int.Parse(usuario.copago));
                  //  txtReporteDatos.Text = sumaCopagos.ToString();
                    MessageBox.Show("Eliminado exitosamente ");
                }

            }
            else
            {
                MessageBox.Show("No hay registros para eliminar ", "Validacion", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                btnReportePila.Enabled = false;
                btnEliminarPila.Enabled = false;
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {

            if (this.colaUsuario.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el primer registro de la Cola? ", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario miEstructura = new EstructuraDatosUsuario();
                    miEstructura = this.colaUsuario.Dequeue();
                    this.reporteCola = this.colaUsuario.Count;
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.colaUsuario.ToArray();
                  //  txtReporteDatos.Text = this.colaUsuario.Count.ToString();
                    MessageBox.Show("Eliminado exitosamente ");
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar ", "Validacion", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                btnReporteCola.Enabled = false;
                btnEliminarCola.Enabled = false;
            }
        }
        private EstructuraDatosUsuario buscarIdUsuario (string identificacion)
        {
            foreach (EstructuraDatosUsuario miEstructura in this.listaUsuario)
            {
                if (miEstructura.identificacion.Equals(identificacion))
                {
                    return miEstructura;
                }
            }return null;
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (this.listaUsuario.Count > 0)
            {
                string idUsuario = this.txtIdentificacion.Text.Trim();
                if (idUsuario.Equals(""))
                {
                    MessageBox.Show("La identificación no debe estar vacio ", "Validacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                    txtIdentificacion.Focus();
                }
                else
                {
                    EstructuraDatosUsuario miEstructura = buscarIdUsuario(idUsuario);
                    if(miEstructura != null)
                    {

                        if (MessageBox.Show("Desea eliminar el registro de la lista? ", "Confirmacion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {//elimnar usuario
                            this.listaUsuario.Remove(miEstructura);
                            this.sumaEdadesLista -= int.Parse(miEstructura.edad);
                            // Calcular el nuevo promedio de las edades
                            double nuevoPromedioEdad = 0;
                            if (this.listaUsuario.Count > 0) // Verificar que la lista no esté vacía
                            {
                                nuevoPromedioEdad = (double)this.sumaEdadesLista / this.listaUsuario.Count;
                            }
                            dgLista.DataSource = null;
                            dgLista.DataSource = this.listaUsuario.ToArray();
                    
                            LimpiarFmr();
                            MessageBox.Show("Eliminado exitosamente ");
                          

                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario identificado con " + idUsuario + "no existe.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar ", "Validacion", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                btnReporteLista.Enabled = false;
                btnEliminarLista.Enabled = false;
            }
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(txtEdad.Text,out num ))
            {
                errorProvider1.SetError(txtEdad, "ingrese solo numeros");
            }
            else
            {
                errorProvider1.SetError(txtEdad, "");
            }
        }

        private void fmrEstructuraDatos_Load(object sender, EventArgs e)
        {

        }

        private void boxDatosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
    }

namespace Evaluacion_Final
{
    public partial class Form1 : Form
    {
        private const string clave = "123";
        private ErrorProvider error;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string laClave = "";
            laClave = this.txtContrasena.Text.Trim();
            if (laClave.Equals(""))
            {
                //  this.error.SetError(this.txtContrasena, "Ingresa la clave correctamente.");
                this.txtContrasena.Focus();
            }
            if (!laClave.Equals(clave))
            {
                this.error.SetError(this.txtContrasena, "Contraseña invalida.");
                this.txtContrasena.Focus();
            }
            else
            {
                //this.error.SetError(this.txtContrasena, null);
                // Crear una instancia del formulario arbolBinario y mostrarlo
                fmrMenu menuOpciones = new fmrMenu();
                menuOpciones.Show();
                this.Hide(); // Oculta el formulario de inicio si no necesitas que siga visible
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
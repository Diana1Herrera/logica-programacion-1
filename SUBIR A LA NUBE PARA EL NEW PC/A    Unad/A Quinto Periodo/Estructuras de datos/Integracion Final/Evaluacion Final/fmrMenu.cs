using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Final
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Fase2DianaHerrera.Form1 fase2 = new Fase2DianaHerrera.Form1();
            fase2.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Fase3DianaCarolinaHerrera.Form1 fase3 = new Fase3DianaCarolinaHerrera.Form1();
            fase3.Show();
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            Fase4DianaHerrera.fmrArbol fase4 = new Fase4DianaHerrera.fmrArbol();
            fase4.Show();
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmrMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

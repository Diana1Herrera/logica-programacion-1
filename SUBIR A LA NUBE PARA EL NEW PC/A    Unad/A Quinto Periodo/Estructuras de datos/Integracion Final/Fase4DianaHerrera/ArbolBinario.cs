
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fase4DianaHerrera
{
    public partial class fmrArbol : Form
    {
        private class Nodo
        {
            public int Valor;
            public Nodo Izquierdo;
            public Nodo Derecho;

            public Nodo(int valor) // metodo
            {
                Valor = valor;
                Izquierdo = null;
                Derecho = null;
            }
        }

        private Nodo raiz;
        private int xInicial = 420; // Coordenada inicial en X para el árbol principal
        private int yInicial = 20;  // Coordenada inicial en Y para el árbol principal
        private int offsetX = 80;   // Espacio horizontal entre nodos
        private int offsetY = 60;   // Espacio vertical entre niveles
        private int xRecorrido = 10; // Coordenada inicial en X para los recorridos
      
        public fmrArbol()
        {
            InitializeComponent();
        }

        private void fmrArbol_MouseMove(object sender, MouseEventArgs e)
        {
            Coordenada1.Text = e.Location.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numeroIngresado))
            {
                if (Buscar(raiz, numeroIngresado))
                {
                    MessageBox.Show("El número ya está en el árbol. No se puede ingresar duplicado.");
                }
                else
                {
                    raiz = Insertar(raiz, numeroIngresado);
                    Refresh(); // Limpia el lienzo para redibujar el árbol y los recorridos
                    DibujarArbol(raiz, xInicial, yInicial, offsetX);
                    DibujarRecorridos();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.");
            }
        }

        private bool Buscar(Nodo nodo, int valor)
        {
            if (nodo == null)
                return false;

            if (nodo.Valor == valor)
                return true;

            if (valor < nodo.Valor)
                return Buscar(nodo.Izquierdo, valor);
            else
                return Buscar(nodo.Derecho, valor);
        }

        private Nodo Insertar(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return new Nodo(valor);
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = Insertar(nodo.Izquierdo, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = Insertar(nodo.Derecho, valor);
            }

            return nodo;
        }

        private void DibujarArbol(Nodo nodo, int x, int y, int offsetX)
        {
            if (nodo == null)
            {
                return;
            }

            // Dibujar subárbol izquierdo
            if (nodo.Izquierdo != null)
            {
                int xIzquierdo = x - offsetX;
                int yNuevo = y + offsetY;

                using (Graphics lienzo = CreateGraphics())
                {
                    lienzo.DrawLine(Pens.DarkCyan, x + 15, y + 15, xIzquierdo + 15, yNuevo + 15);
                }

                DibujarArbol(nodo.Izquierdo, xIzquierdo, yNuevo, offsetX / 2);
            }

            // Dibujar subárbol derecho
            if (nodo.Derecho != null)
            {
                int xDerecho = x + offsetX;
                int yNuevo = y + offsetY;

                using (Graphics lienzo = CreateGraphics())
                {
                    lienzo.DrawLine(Pens.DarkCyan, x + 15, y + 15, xDerecho + 15, yNuevo + 15);
                }

                DibujarArbol(nodo.Derecho, xDerecho, yNuevo, offsetX / 2);
            }

            // Dibujar el nodo actual
            using (Graphics lienzo = CreateGraphics())
            {
                using (Pen lapiz = new Pen(Brushes.DarkCyan, 3))
                {
                    lienzo.FillEllipse(Brushes.Cyan, x, y, 30, 30);
                    lienzo.DrawEllipse(lapiz, x, y, 30, 30);

                    // Dibujar el número dentro del nodo
                    Font fuente = new Font("Arial", 12);
                    StringFormat formato = new StringFormat();
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;
                    lienzo.DrawString(nodo.Valor.ToString(), fuente, Brushes.Black, new RectangleF(x, y, 30, 30), formato);
                }
            }
        }

        private void DibujarRecorridos()
        {
            // Dibujar los recorridos en los lienzos correspondientes
            using (Graphics preordenLienzo = CreateGraphics())
            {
                int yPreorden = 440;// Posición Y para el recorrido preorden
                xRecorrido = 10; // Reiniciar la coordenada X para el inicio de los recorridos
                DibujarRecorridoPreorden(raiz, preordenLienzo, yPreorden);
            }

            using (Graphics inordenLienzo = CreateGraphics())
            {
                xRecorrido = 10; // Reiniciar la coordenada X para el inicio de los recorridos
                int yPreorden = 515;
                DibujarRecorridoInorden(raiz, inordenLienzo, yPreorden);
            }

            using (Graphics posordenLienzo = CreateGraphics())
            {
                xRecorrido = 10; // Reiniciar la coordenada X para el inicio de los recorridos
                int yPreorden = 578;
                DibujarRecorridoPosorden(raiz, posordenLienzo, yPreorden);
            }
        }

        private void DibujarRecorridoPreorden(Nodo nodo, Graphics lienzo, int y)
        {
            if (nodo == null)
                return;

            DibujarNodoRecorrido(nodo, lienzo, Brushes.Cyan,y);//Nodo actual → Subárbol izquierdo → Subárbol derecho.
            DibujarRecorridoPreorden(nodo.Izquierdo, lienzo,y);
            DibujarRecorridoPreorden(nodo.Derecho, lienzo,y);
        }

        private void DibujarRecorridoInorden(Nodo nodo, Graphics lienzo, int y)
        {
            if (nodo == null)
                return;

            DibujarRecorridoInorden(nodo.Izquierdo, lienzo, y); //Subárbol izquierdo → Nodo actual → Subárbol derecho.
            DibujarNodoRecorrido(nodo, lienzo, Brushes.Cyan,y);
            DibujarRecorridoInorden(nodo.Derecho, lienzo, y);
        }

        private void DibujarRecorridoPosorden(Nodo nodo, Graphics lienzo, int y)
        {
            if (nodo == null)
                return;

            DibujarRecorridoPosorden(nodo.Izquierdo, lienzo, y); //Llama al método para recorrer el subárbol izquierdo
            DibujarRecorridoPosorden(nodo.Derecho, lienzo, y);
            DibujarNodoRecorrido(nodo, lienzo, Brushes.Cyan,y);// dibuja el nodo actual
        }

        private void DibujarNodoRecorrido(Nodo nodo, Graphics lienzo, Brush color, int y)
        {
           // El bloque using asegura que los recursos gráficos,se liberen automáticamente después de su uso.

            using (Pen lapiz = new Pen(Brushes.DarkCyan, 2))
            {
                lienzo.FillEllipse(color, xRecorrido, y, 27, 27); //Dibuja un círculo relleno
                lienzo.DrawEllipse(lapiz, xRecorrido, y, 27, 27); // contorno

                // Dibujar el número dentro del nodo
                Font fuente = new Font("Arial", 9);
                StringFormat formato = new StringFormat();
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;
                lienzo.DrawString(nodo.Valor.ToString(), fuente, Brushes.Black, new RectangleF(xRecorrido, y, 30, 30), formato);//Escribe el valor del nodo

                // Ajustar la posición X para el siguiente nodo en el recorrido
                xRecorrido += 40; //Incrementa el valor 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrArbol_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triorama
{
    public partial class Form1 : Form
    {
        int puntuaje = 0, cartasVolt = 0, cartaActu = 0;
        List<string> cartasEnumeradas;
        List<String> cartasRevueltas;
        ArrayList seleccion;
        PictureBox cartaTemporalA;
        PictureBox cartaTemporalB;
        PictureBox cartaTemporalC;


        public Form1()
        {
            InitializeComponent();
            NuevoJuego();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("¿Realmente quiere salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                return;
            }
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            NuevoJuego();
        }


        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (seleccion.Count < 3)
            {
                var cardselectuser = (PictureBox)sender;
                cartaActu = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cardselectuser.Name) - 1]);
                cardselectuser.Image = Recuperar(cartaActu);
                seleccion.Add(cardselectuser);
                if (seleccion.Count == 3)
                {
                    cartaTemporalA = (PictureBox)seleccion[0];
                    cartaTemporalB = (PictureBox)seleccion[1];
                    cartaTemporalC = (PictureBox)seleccion[2];
                    int cartaA = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporalA.Name) - 1]);
                    int cartaB = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporalB.Name) - 1]);
                    int cartaC = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporalC.Name) - 1]);
                    if (cartaA != cartaB || cartaA != cartaC)
                    {
                        tmr.Enabled = true;
                        tmr.Start();
                    }
                    else
                    {
                        puntuaje++;
                        lblPuntos.Text = puntuaje.ToString();
                        if (puntuaje > 5)
                        {
                            MessageBox.Show("¡Felicidades, has ganado!");
                        }
                        cartaTemporalA.Enabled = false;
                        cartaTemporalB.Enabled = false;
                        cartaTemporalC.Enabled = false;
                        seleccion.Clear();
                    }
                }
                cartasVolt++;
                lblmove.Text = cartasVolt.ToString();
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                cartaTemporalA.Image = Properties.Resources._7;
                cartaTemporalB.Image = Properties.Resources._7;
                cartaTemporalC.Image = Properties.Resources._7;
                seleccion.Clear();
                TiempoVirarCarta = 0;

            }
            if (TiempoVirarCarta == 0)
            {
                tmr.Stop();
            }
        }

        public void NuevoJuego()
        {
            tmr.Enabled = false;
            tmr.Stop();
            lblPuntos.Text = "0";
            cartasVolt = 0;
            puntuaje = 0;
            lblmove.Text = "0";
            pnlJuego.Controls.Clear();
            cartasEnumeradas = new List<string>();
            cartasRevueltas = new List<string>();
            seleccion = new ArrayList();
            for (int i = 0; i < 6; i++)
            {
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());
            }
            var numAle = new Random();
            var res = cartasEnumeradas.OrderBy(item => numAle.Next());
            string cadena = "";
            foreach (string valCar in res)
            {
                cartasRevueltas.Add(valCar);
                cadena += valCar.ToString() + ", ";
            }
            trampa.Text = cadena;
            var tabla = new TableLayoutPanel();
            tabla.RowCount = 3;
            tabla.ColumnCount = 6;

            for (int i = 0; i < 6; i++)
            {
                var porcent = 150f / (float)6 - 10;
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcent));
                tabla.RowStyles.Add(new RowStyle(SizeType.Percent, porcent));
            }
            int contador = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var cartaJuego = new PictureBox();
                    cartaJuego.Name = string.Format("{0}", contador);
                    cartaJuego.Dock = DockStyle.Fill;
                    cartaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartaJuego.Image = Properties.Resources._7;
                    cartaJuego.Cursor = Cursors.Hand;
                    cartaJuego.Click += btnCarta_Click;
                    tabla.Controls.Add(cartaJuego, j, i);
                    contador++;
                }
            }
            tabla.Dock = DockStyle.Fill;
            pnlJuego.Controls.Add(tabla);
        }

        public Bitmap Recuperar (int num)
        {
            Bitmap tmpimg = new Bitmap(200, 100);
            tmpimg = (Bitmap)Properties.Resources.ResourceManager.GetObject((num+ 1).ToString()) ;
            
            return tmpimg;
        }
    }
}

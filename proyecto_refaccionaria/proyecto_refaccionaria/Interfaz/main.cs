using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_refaccionaria.Interfaz;
using proyecto_refaccionaria.BD;

namespace proyecto_refaccionaria
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
                        basedatos bd = new basedatos();
            if (bd.Conectar())
            {
                
                    MessageBox.Show("funcionando");
                }
                else
                {
                    MessageBox.Show("rechazado");
                }
            bd.Desconectar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsultarP consultap = new FrmConsultarP();
            consultap.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El producto no se eliminara del todo solo desaparecera del catalogo de productos");
            FrmBaja baja = new FrmBaja();
            baja.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_modificar modificar = new Frm_modificar();
            modificar.Show();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_alta alta = new Frm_alta();
            alta.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world inc \n hecho por LOS EXILIADOS TEAM");
            MessageBox.Show("nadie quiere aparecer aqui :C");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("para ayuda preguntarle a nacho");
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_consultaV consultaV = new Frm_consultaV();
            consultaV.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ventapro v = new Frm_ventapro();
            v.ShowDialog();

            }

        private void main_Load(object sender, EventArgs e)
        {

        }
            
            
        }
}


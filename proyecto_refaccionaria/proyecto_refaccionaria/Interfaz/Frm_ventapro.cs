using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_refaccionaria.BD;
using proyecto_refaccionaria.clases;
using proyecto_refaccionaria.control;

namespace proyecto_refaccionaria.Interfaz
{
    public partial class Frm_ventapro : Form
    {
        public Frm_ventapro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnagregarc_Click(object sender, EventArgs e)
        {
            Frm_venta vv = new Frm_venta();
            vv.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ventapro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            if (bd.Conectar())
            {
                try
                {
                    producto mproducto = new producto();
                    mproducto.Nombre = txtname.Text;
                    mproducto.marca = txtmarca.Text;
                    controlproducto mcontrol = new controlproducto();

                    tproductos.DataSource = mcontrol.consultarproductos(mproducto).Tables;
                }
                catch (Exception)
                {
                    MessageBox.Show("error  al buscar el producto");
                }
            }
            else
            {
                MessageBox.Show("error con la base de datos");
            }
            bd.Desconectar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class FrmConsultarP : Form
    {
        public FrmConsultarP()
        {
            InitializeComponent();
        }

        private void FrmConsultarP_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            if (bd.Conectar())
            {
                try
                {
                    producto mproducto = new producto();
                    controlproducto mcontrol = new controlproducto();

                    if (txtmarca == null) {
                        mproducto.Nombre = txtname.Text;
                       
                        tproductos.DataSource = null;
                        tproductos.DataSource = mcontrol.consultarproductos(mproducto).Tables[0];
                    }
                    else
                    {
                        mproducto.Nombre = txtname.Text;
                        mproducto.marca = txtmarca.Text;
                        tproductos.DataSource = null;
                        tproductos.DataSource = mcontrol.consultarproductos(mproducto).Tables[0];
                    }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

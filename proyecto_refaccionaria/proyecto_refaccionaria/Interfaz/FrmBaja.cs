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
    public partial class FrmBaja : Form
    {
        public FrmBaja()
        {
            InitializeComponent();
        }

        private void FrmBaja_Load(object sender, EventArgs e)
        {
            controlproducto mcontrol = new controlproducto();
            tproducto.DataSource = mcontrol.consultartodosproductos().Tables;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("estas seguro", "advertencia", MessageBoxButtons.YesNo);
            if(resultado== DialogResult.Yes)
            {
                producto mproducto = new producto();
                mproducto.id_producto = (int)tproducto.SelectedRows[0].Cells[0].Value;
                controlproducto mControl = new controlproducto();
                mControl.Eliminarproducto(mproducto);
                MessageBox.Show("producto eliminado");
            }else if (resultado==DialogResult.No){
                
            }
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscarr_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            if (bd.Conectar())
            {
                 try
                {
                    producto mproducto = new producto();
                    mproducto.Nombre = txtnombre.Text;
                    controlproducto mcontrol = new controlproducto();

                    tproducto.DataSource = mcontrol.consultarproductos(mproducto).Tables[0];
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
    }
}

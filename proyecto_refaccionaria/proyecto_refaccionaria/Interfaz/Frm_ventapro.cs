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
            if (cantidad.Text != null)
            {


                foreach (DataGridViewRow row in tproductos.SelectedRows)
                {

                    producto mproducto = new producto();
                    detalles_venta dventa = new detalles_venta();


                    mproducto.id_producto = int.Parse(this.tproductos.CurrentRow.Cells[0].Value.ToString());
                    mproducto.Nombre = this.tproductos.CurrentRow.Cells[1].Value.ToString();
                    mproducto.tipo = this.tproductos.CurrentRow.Cells[2].Value.ToString();
                    mproducto.descripcion = this.tproductos.CurrentRow.Cells[3].Value.ToString();
                    mproducto.precio = float.Parse(this.tproductos.CurrentRow.Cells[4].Value.ToString());
                    mproducto.marca = this.tproductos.CurrentRow.Cells[5].Value.ToString();
                    dventa.cantidad = int.Parse(cantidad.Text);

                    carrito.Rows.Add(mproducto.id_producto, mproducto.Nombre, mproducto.tipo,
                        mproducto.descripcion, mproducto.precio, mproducto.marca, dventa.cantidad);

                }
            }
            else
            {
                MessageBox.Show("por favor selecciona una cantidad");
            }
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

        private void Frm_ventapro_Activated(object sender, EventArgs e)
        {
            controlproducto mControl = new controlproducto();
            tproductos.DataSource = mControl.consultartodosproductos().Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tproductos_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            txtname.Text = row.Cells[1].Value.ToString();
            txtmarca.Text = row.Cells[5].Value.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ventas mventa = new ventas();
            mventa.total = 0;
            detalles_venta mdv = new detalles_venta();
            mdv.cantidad = 0;
            float total1 = 0;

            ArrayList venta = new ArrayList();
            for (int i = 0; i < carrito.RowCount;i++ )
            {
                venta.Add(carrito.Columns[0]);
            }
            DialogResult resultado = MessageBox.Show("estas seguro de la venta", "atencion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                
                
                foreach (DataGridViewRow row in carrito.Rows)
                {
                   total1 = (float)row.Cells[4].Value;
                   mdv.cantidad = (int)row.Cells[6].Value;
                   mventa.total += total1 * (float)mdv.cantidad;
                }
                //MessageBox.Show(mventa.total.ToString());
                Frm_Ventapagar m = new Frm_Ventapagar();
                mventa.fecha = dtpventa.Value;
                control_Ventas mcv = new control_Ventas();
                mcv.agregarventa(mventa);
                m.txttot.Text = mventa.total.ToString();
                m.ShowDialog();
                this.Close();
                
            }else if(resultado==DialogResult.No)
            {
                MessageBox.Show("cancelado");
            }
        }
    }
}

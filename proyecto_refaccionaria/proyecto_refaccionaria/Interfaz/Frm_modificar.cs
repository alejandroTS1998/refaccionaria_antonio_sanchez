using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_refaccionaria.clases;
using proyecto_refaccionaria.control;

namespace proyecto_refaccionaria.Interfaz
{
    public partial class Frm_modificar : Form
    {
        public Frm_modificar()
        {
            InitializeComponent();
        }

        private void Frm_modificar_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarI_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.FileName = "";
            
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = this.ruta.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                
                this.ruta.Text = BuscarImagen.FileName;
                
                String Direccion = BuscarImagen.FileName;
                this.pbproductos.ImageLocation = Direccion;
                
                pbproductos.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            producto mproducto = new producto();
            mproducto.Nombre = txtnombre.Text;
            mproducto.descripcion = txtdescripcion.Text;
            mproducto.marca = txtmarca.Text;
            mproducto.precio = float.Parse(txtprecio.Text);
            mproducto.tipo = cbtipo.Text;
            mproducto.ruta = ruta.Text;

            mproducto.id_producto = (int)Tproductos.SelectedRows[0].Cells[0].Value;
            
            controlproducto mControl = new controlproducto();
            mControl.modificarproducto(mproducto);
            MessageBox.Show("Producto modificado");
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtnombre.Clear();
            txtprecio.Clear() ;
            
            Tproductos.DataSource = mControl.consultartodosproductos().Tables[0];
        }

        private void Frm_modificar_Activated(object sender, EventArgs e)
        {
            controlproducto mControl = new controlproducto();
            Tproductos.DataSource = mControl.consultartodosproductos().Tables[0];
        }

        private void Tproductos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

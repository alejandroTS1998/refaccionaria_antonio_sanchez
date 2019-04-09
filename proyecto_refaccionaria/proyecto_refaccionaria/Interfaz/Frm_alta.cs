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
    public partial class Frm_alta : Form
    {
        public Frm_alta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_alta_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            if (bd.Conectar())
            {

                try
                {
                    producto mproducto = new producto();
                    mproducto.Nombre = txtnombre.Text;
                    mproducto.descripcion = txtdescripcion.Text;
                    mproducto.tipo = txttipo.Text;
                    mproducto.precio = float.Parse(txtprecio.Text);
                    mproducto.ruta = ruta.Text;
                    controlproducto mcontrol = new controlproducto();
                    mcontrol.agregarproducto(mproducto);
                    MessageBox.Show("producto agregado");
                }
                catch (Exception)
                {
                    MessageBox.Show("error  al agregar el producto");
                }
            }
            else
            {
                MessageBox.Show("error con la base de datos");
            }
            bd.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
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
                this.pictureBox3.ImageLocation = Direccion;

                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

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
    public partial class Frm_Ventapagar : Form
    {
        public Frm_Ventapagar()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Ventapagar_Load(object sender, EventArgs e)
        {
            
 
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            control_Ventas cv = new control_Ventas();
            float cambio = 0;
            cambio = (float.Parse(txtefectivo.Text)-float.Parse(txttot.Text));
            Cambiox.Text = cambio.ToString();
            if(float.Parse(txttot.Text)>float.Parse(txtefectivo.Text))
            {
                MessageBox.Show("el efectivo es insuficiente, por favor ingrese otro monto");
            }
            else
            {
                MessageBox.Show("su cambio es de :" + cambio);
                MessageBox.Show("que tenga un excelente dia");
                this.Close();
            }
        }
    }
}

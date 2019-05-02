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
    public partial class Frm_consultaV : Form
    {
        public Frm_consultaV()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarp_Click(object sender, EventArgs e)
        {
                        basedatos bd = new basedatos();
            if (bd.Conectar())
            {
                try
                {     
                 ventas mventas = new ventas();
                  control_Ventas mcontrol = new control_Ventas();
                  tventa.DataSource = null;
                    if(mventas.fecha.ToString()==fechad.Text)
                    {

                        tventa.DataSource = mcontrol.consultarventa(mventas).Tables[0];
                    }           
                }
                catch (Exception)
                {
                    MessageBox.Show("error  al buscar las ventas");
                }
            }
            else
            {
                MessageBox.Show("error con la base de datos");
            }
            bd.Desconectar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_refaccionaria.Interfaz
{
    public partial class Frm_venta : Form
    {
        public Frm_venta()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿estas seguro de cancelar?", "advertencia", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            Frm_Ventapagar vvv = new Frm_Ventapagar();
            vvv.ShowDialog();
        }
    }
}

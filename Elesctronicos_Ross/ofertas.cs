using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elesctronicos_Ross
{
    public partial class ofertas : Form
    {
        public ofertas()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_oferta(dataGridView1);
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "SELECT NOMBRE_PRODUCTO_ANGEL FROM PRODUCTOS_ANGEL");
            
        }
        private void ofertas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fecha = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha de vencimiento de la oferta");
            String desc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el descuento en %");
            String prod = comboBox1.Text;

            conexion_maestra_angel.ejecutar_angel("EXEC pcd_inserta_oferta '" + prod + "', '" + desc + "', '" + fecha + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_oferta(dataGridView1);
        }
    }
}

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
    public partial class repair : Form
    {
        public repair()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_repair(dataGridView1);
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "select NOMBRE_PRODUCTO_ANGEL from PRODUCTOS_ANGEL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prod = comboBox1.Text;
            String fechae = Microsoft.VisualBasic.Interaction.InputBox("Fecha de entrega: ");
            String descrip = Microsoft.VisualBasic.Interaction.InputBox("Detalles a reparar: ");

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_inserta_reparacion '" + prod + "','" + fechae + "','" + descrip + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_repair(dataGridView1);
        }
    }
}

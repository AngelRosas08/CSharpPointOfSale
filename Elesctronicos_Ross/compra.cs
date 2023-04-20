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
    public partial class compra : Form
    {
        public compra()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_compra(dataGridView1);
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "SELECT RAZON_SOCIAL_PROVEEDOR_ANGEL FROM PROVEEDOR_ANGEL");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String prov = comboBox1.Text;
            String folio = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el folio de la compra");
            String total = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el total");


            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_compra '" + folio + "','" + prov + "','" + total + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_compra(dataGridView1);
        }

        private void compra_Load(object sender, EventArgs e)
        {

        }
    }
}

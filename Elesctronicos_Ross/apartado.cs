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
    public partial class apartado : Form
    {
        public apartado()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_apart(dataGridView1);
        }

        private void apartado_Load(object sender, EventArgs e)
        {
            conexion_maestra_angel.abrir_angel();
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "SELECT NOMBRE_PRODUCTO_ANGEL FROM PRODUCTOS_ANGEL");
            conexion_maestra_angel.angel_llenaCombo(comboBox2, "SELECT RAZON_SOCIAL_CLIENTE_ANGEL FROM CLIENTE_ANGEL");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String prod = comboBox1.Text;
            String client = comboBox2.Text;
            String prec = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio");

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_apartado '" + prod + "','" + client + "','" + prec + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_apart(dataGridView1);
        }

    }
}

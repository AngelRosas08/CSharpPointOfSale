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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_productos(datos);
            conexion_maestra_angel.angel_llenaCombo(comboBox3, "SELECT [NOMBRE_MARCA_ANGEL] FROM MARCA_ANGEL");
            conexion_maestra_angel.angel_llenaCombo(comboBox2, "SELECT [NOMBRE_CATEGORIA] FROM CATEGORIA_ANGEL");
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "SELECT [RAZON_SOCIAL_PROVEEDOR_ANGEL] FROM PROVEEDOR_ANGEL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String clave = textBox1.Text;
            String nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del producto: ");
            String marca = comboBox3.Text;
            String precio = Microsoft.VisualBasic.Interaction.InputBox("Precio del producto: ");
            String categoria = comboBox2.Text;
            String prov = comboBox1.Text;

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_producto '" + clave + "','" + nombre + "','" + marca + "','" + precio+ "','" + categoria + "','" + prov + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_productos(datos);
        }

        private void productos_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            conexion_maestra_angel.grid(datos, "EXEC pcd_buscar_productos '%" + txtInfo.Text + "%'");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                button3_Click_1(sender, e);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}

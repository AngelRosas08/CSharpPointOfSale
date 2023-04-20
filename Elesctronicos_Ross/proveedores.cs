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
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_prov(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String clave = textBox1.Text;
            String razon = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la razon social");
            String nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre");
            String direc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la direccion");
            String tel = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su numero telefonico");
            String correo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una direccionde correo");


            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_proveed '" + clave + "','" + razon + "','" + nombre + "','" + direc + "','" + tel + "','" + correo + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_prov(dataGridView1);
        }
    }
}

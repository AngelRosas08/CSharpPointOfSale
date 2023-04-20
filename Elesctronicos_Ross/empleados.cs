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
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_empleado(dataGridView1);
            conexion_maestra_angel.angel_llenaCombo(comboBox1, "SELECT NOMBRE_CARGO_ANGEL FROM CARGO_ANGEL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cargo = comboBox1.Text;
            String rfc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el RFC del nuevo empleado");
            String nom = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre");
            String ap1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido paterno");
            String ap2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido materno");
            String direc = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la direccion");
            String tel = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el telefono");
            String email = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el correo");

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_empleado '" + rfc + "','" + nom + "','" + ap1 + "','" + ap2 + "','" + direc + "','" + tel + "','" + email + "','" + cargo + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_empleado(dataGridView1);
        }
    }
}

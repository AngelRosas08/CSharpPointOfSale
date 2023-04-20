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
    public partial class marca : Form
    {
        public marca()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_marca(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una nueva Marca");


            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_marca '" + nombre + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_marca(dataGridView1);
        }
    }
}

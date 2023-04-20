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
    public partial class cargos : Form
    {
        public cargos()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_cargo(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cargo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo cargo");
            String descrip = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la descripcion del nuevo cargo");

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_cargo '" + cargo + "','" + descrip + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_cargo(dataGridView1);
        }

        private void cargos_Load(object sender, EventArgs e)
        {

        }
    }
}

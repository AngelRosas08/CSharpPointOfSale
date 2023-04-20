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
    public partial class categoria : Form
    {
        public categoria()
        {
            InitializeComponent();
            conexion_maestra_angel.llenar_grid_categoria(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categ = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una Categoria");
            String descrip = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la descripcion de la categoria");

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_categoria '" + categ + "','" + descrip + "'");
            conexion_maestra_angel.leer_angel.Close();
            conexion_maestra_angel.llenar_grid_categoria(dataGridView1);

        }
    }
}

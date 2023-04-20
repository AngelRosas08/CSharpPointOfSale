using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Elesctronicos_Ross
{
    public partial class venta : Form
    {
        private Worksheet hoja;

        public venta()
        {
            InitializeComponent();
            conexion_maestra_angel.angel_llenaCombo(comboBox2, "SELECT NOMBRE_EMPLEADO_ANGEL FROM EMPLEADOS_ANGEL");
        }

        private void venta_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            textBox2.Text = thisDay.ToString("ddMMyyyyhhmmssff");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String precio = textBox1.Text;
            String empleado = comboBox2.Text;
            String folio = textBox2.Text;
            String cantidad = textBox4.Text;
            String clave = textBox3.Text;

            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_insertar_venta '" + folio + "','" + clave + "','" + cantidad + "','" + empleado + "','" + precio + "'");
            conexion_maestra_angel.leer_angel.Close();
            Microsoft.VisualBasic.Interaction.MsgBox("Venta ingresada correctamente");
            conexion_maestra_angel.grid(tabVentas, "exec pcd_ver_venta '" + clave + "','" + folio + "'");
            conexion_maestra_angel.leer_angel.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            String folio = textBox2.Text;
            String clave = textBox3.Text;
            conexion_maestra_angel.ejecutar_angel("EXECUTE pcd_eliminar_venta '" + folio + "'");
            conexion_maestra_angel.leer_angel.Close();
            Microsoft.VisualBasic.Interaction.MsgBox("Venta Eliminada");
            conexion_maestra_angel.grid(tabVentas, "exec pcd_ver_venta '" + clave + "','" + folio + "'");
            conexion_maestra_angel.leer_angel.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            venta venta = new venta();
            venta.Show();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                button3_Click(sender, e);
                //textBox3.Focus();
                //Microsoft.VisualBasic.Interaction.InputBox("correcto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String precio = textBox1.Text;
            String empleado = comboBox2.Text;
            String folio = textBox2.Text;
            String cantidad = textBox4.Text;
            String clave = textBox3.Text;
            Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("VENTA_ANGEL");
            aplicacion.Visible = true;
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[3, 8] = folio;
            hoja.Cells[6, 3] = empleado;
            hoja.Cells[12, 7] = precio;
            libro.PrintOutEx();
            //libro.SaveAs(@"C:\Users\Dell\Documents\VENTA_ANGEL");
            //aplicacion.Quit();
        }
    }
}

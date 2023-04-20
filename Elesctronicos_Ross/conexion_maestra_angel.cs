using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Elesctronicos_Ross
{
    internal class conexion_maestra_angel
    {
        static string servidor_angel = "PC1";
        static string baseDatos_angel = "Electronicos_Ross";
        static string seguridad_angel = "true";
        static string cadena_angel = "DATA SOURCE=" + servidor_angel + ";DATABASE=" + baseDatos_angel + "; Integrated security=" + seguridad_angel;

        public static SqlConnection conectar_angel = new SqlConnection(cadena_angel);
        public static SqlCommand consulta_angel;    //servira para poner cualquier tipo de consultas
        public static SqlDataReader leer_angel;     //nos permite amacenar y acceder temporalmente al resultado de una consulta de sql
        DataSet cuadricula_angel = new DataSet();

        public static void abrir_angel()
        {
            if (conectar_angel.State == ConnectionState.Closed)
            {
                conectar_angel.Open();
                consulta_angel = new SqlCommand();
                consulta_angel.Connection = conectar_angel;
            }
        }
        public static void ejecutar_angel(string angel_SQL)
        {
            consulta_angel.CommandType = System.Data.CommandType.Text;
            consulta_angel.CommandText = angel_SQL;
            leer_angel = consulta_angel.ExecuteReader();
            //leer_angel.Close();
        }
        public static void angel_llenaCombo(ComboBox angel_combo, string angelSQL)
        {
            ejecutar_angel(angelSQL);
            angel_combo.Items.Clear();
            while (leer_angel.Read())
            {
                angel_combo.Items.Add(leer_angel[0]);
            }
            leer_angel.Close();
        }
        public static void grid(DataGridView tabla, string sql)
        {
            ejecutar_angel(sql);
            leer_angel.Close();
            DataSet cuadricula_angel = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_angel);
            adaptador.Fill(cuadricula_angel, "datos");
            tabla.DataSource = cuadricula_angel;
            tabla.DataMember = "datos";
            cuadricula_angel.AcceptChanges();
        }
        public static void llenar_grid_cliente(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENTE_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_cargo(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CARGO_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_categoria(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORIA_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_marca(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MARCA_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_prov(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PROVEEDOR_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_apart(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM APARTADO_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_compra(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPRA_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_empleado(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EMPLEADOS_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_oferta(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OFERTA_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_repair(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REPARACION_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        public static void llenar_grid_productos(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PRODUCTOS_ANGEL", conectar_angel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}

    


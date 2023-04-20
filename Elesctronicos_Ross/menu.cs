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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion_maestra_angel.abrir_angel();
            panel1.Dock = DockStyle.Fill;
            /*pictureBox1.Image = Image.FromFile(@"C:\Users\Dell\source\repos\Elesctronicos_Ross\fondo\elec.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"C:\Users\Dell\source\repos\Elesctronicos_Ross\fondo\imag.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cargos cargos = new cargos();
            cargos.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            categoria cat = new categoria();
            cat.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            marca marca = new marca();
            marca.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();
            prov.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            apartado apartado = new apartado();
            apartado.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            compra compra = new compra();
            compra.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            empleados empleados = new empleados();
            empleados.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ofertas ofertas = new ofertas();
            ofertas.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            repair repair = new repair();
            repair.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            productos productos = new productos();
            productos.Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatsapp.com/");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://es-la.facebook.com/");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/?lang=es");
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Silver;
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Silver;
        }
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Silver;
        }
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Silver;
        }
        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
        }
        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Silver;
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Silver;
        }
        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.White;
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Silver;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            venta venta = new venta();
            venta.Show();
        }
        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackColor = Color.White;
        }
        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.Silver;
        }
    }
}

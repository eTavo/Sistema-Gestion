using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            nRegistroUsuarios usuario = new nRegistroUsuarios();
            usuario.guardar(txtnombre.Text, txtapellido.Text, txtcorreo.Text, txtpass.Text);

            txtnombre.Text = null;
            txtnombre.Refresh();

            txtapellido.Text = null;
            txtapellido.Refresh();
    
            txtcorreo.Text = null;
            txtcorreo.Refresh();

            txtpass.Text = null;
            txtpass.Refresh();

            datagrid.DataSource = null;
            datagrid.DataSource = usuario.obtener();
            datagrid.Refresh();       
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            nRegistroUsuarios dato = new nRegistroUsuarios();
            dato.eliminar();

            txtnombre.Text = null;
            txtnombre.Refresh();

            txtapellido.Text = null;
            txtapellido.Refresh();

            txtcorreo.Text = null;
            txtcorreo.Refresh();

            txtpass.Text = null;
            txtpass.Refresh();

            datagrid.DataSource = null;
            datagrid.DataSource = dato.obtener();
            datagrid.Refresh();
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = datagrid.CurrentRow.Cells[0].Value.ToString();
            txtapellido.Text = datagrid.CurrentRow.Cells[1].Value.ToString(); ;
            txtcorreo.Text = datagrid.CurrentRow.Cells[2].Value.ToString();
            txtpass.Text = datagrid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

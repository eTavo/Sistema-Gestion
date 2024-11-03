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
            usuario.guardar(apellidotxt.Text, usuariotxt.Text, correo.Text, txtpass.Text);

            apellidotxt.Text = null;
            apellidotxt.Refresh();

            usuariotxt.Text = null;
            usuariotxt.Refresh();
            
            correo.Text = null;
            correo.Refresh();

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


            datagrid.DataSource = null;
            datagrid.DataSource = dato.obtener();
            datagrid.Refresh();
        }
    }
}

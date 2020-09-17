using System;
using System.Windows.Forms;

namespace App_regitros_filtro.UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes clientes = FormClientes.ObtenerIntancia();
            clientes.MdiParent = this;
            clientes.Show();
            clientes.BringToFront();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros libros = FormLibros.obtenerIntacniaL();
            libros.MdiParent = this;
            libros.Show();
            libros.BringToFront();

        }
    }
}

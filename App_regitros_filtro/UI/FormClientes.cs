using System;
using System.Windows.Forms;
using App_regitros_filtro.DAO;

namespace App_regitros_filtro.UI
{
    public partial class FormClientes : Form
    {
        //PATRON SINGLETON
        private FormClientes() { 
            InitializeComponent();
        }
        private static FormClientes intancia = null;
        //este metodo se encargara de realizar la intancia publica
        public static FormClientes ObtenerIntancia()
        {
            if (intancia == null){ intancia = new FormClientes(); }
            return intancia;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            //ver todos
            verClientes("");
        }

        //metodo buscar registros
        private void verClientes(string condicion)
        {
            ClienteDao client = new ClienteDao();
            dataGridView1.DataSource = client.verRegistros(condicion);
        }
        //BUscar 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            verClientes(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            verClientes(txtBuscar.Text);
        }
    }
}

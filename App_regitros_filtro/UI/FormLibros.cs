using System.Windows.Forms;

namespace App_regitros_filtro.UI
{
    public partial class FormLibros : Form
    {
        private FormLibros() { 
            InitializeComponent();
        }

        private static FormLibros intanciaL = null;
        public static FormLibros obtenerIntacniaL()
        {
            if (intanciaL == null) { intanciaL = new FormLibros(); }
            return intanciaL;
        }
    }
}

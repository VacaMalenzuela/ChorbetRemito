using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Dominio;

namespace ChorbetRemito
{
    public partial class FormRemito : Form
    {
        public FormRemito()
        {
            InitializeComponent();
        }

        private void FormRemito_Load(object sender, EventArgs e)
        {
            CargarBox();
        }

        public void CargarBox()
        {
            ClienteNegocio negocioc = new ClienteNegocio();
            ProductoNegocio negociop = new ProductoNegocio();
            try
            {
                cbxClientes.DataSource = negocioc.listarNombres();
                cbxProductos.DataSource = negociop.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

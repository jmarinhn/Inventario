using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agreagar la libreria Mysql dentro de la Rerencias del proyecto inventario1
using MySql.Data.MySqlClient;


namespace Inventario
{
    public partial class FormBuscarProve : Form
    {
        public FormBuscarProve()
        {
            InitializeComponent();
        }


        public Proveedores ProveedorSeleccionado { get; set; }


        private void FormBuscarProve_Load(object sender, EventArgs e)
        {
            

        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            dataGridBuscar.DataSource = ProveedoresDal.Buscar(nombrebuscar.Text, apellidobuscar.Text);
        }

        private void cargarBD_Click_1(object sender, EventArgs e)
        {
            dataGridBuscar.DataSource = ProveedoresDal.Buscar2();
        }

        private void agregar_Click_1(object sender, EventArgs e)
        {
            if (dataGridBuscar.SelectedRows.Count == 1)
            {
                int linea = Convert.ToInt32(dataGridBuscar.CurrentRow.Cells[0].Value);
                ProveedorSeleccionado = ProveedoresDal.ObtenerProveedor(linea);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }
}
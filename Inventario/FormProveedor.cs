using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Proveedores pProveedor = new Proveedores();

            pProveedor.cod_proveedor = Convert.ToInt16(codigo.Text);
            pProveedor.nombre = nombre.Text.Trim();
            pProveedor.apellido = apellido.Text.Trim();
            pProveedor.telefono1 = tele1.Text.Trim();
            pProveedor.telefono2 = tele2.Text.Trim();
            pProveedor.direccion = direc.Text.Trim();
            pProveedor.email = email.Text.Trim();
            


            int resultado = ProveedoresDal.Agregar(pProveedor);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public Proveedores ProveedorActual { get; set; }

        private void buscar_Click_1(object sender, EventArgs e)
        {

            FormBuscarProve buscar = new FormBuscarProve();
            buscar.ShowDialog();



            if (buscar.ProveedorSeleccionado != null)
            {


                ProveedorActual = buscar.ProveedorSeleccionado;

                codigo.Text = Convert.ToString(buscar.ProveedorSeleccionado.cod_proveedor);

                ////bloqueo de la caja de texto
                codigo.Enabled = false;
                nombre.Text = buscar.ProveedorSeleccionado.nombre;
                apellido.Text = buscar.ProveedorSeleccionado.apellido;
                tele1.Text = buscar.ProveedorSeleccionado.telefono1;
                tele2.Text = buscar.ProveedorSeleccionado.telefono2;
                direc.Text = buscar.ProveedorSeleccionado.direccion;
                email.Text = buscar.ProveedorSeleccionado.email;
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            FormBuscarProve buscar = new FormBuscarProve();
            buscar.ShowDialog();



            if (buscar.ProveedorSeleccionado != null)
            {


                ProveedorActual = buscar.ProveedorSeleccionado;

                codigo.Text = Convert.ToString(buscar.ProveedorSeleccionado.cod_proveedor);

                ////bloqueo de la caja de texto
                codigo.Enabled = false;
                nombre.Text = buscar.ProveedorSeleccionado.nombre;
                apellido.Text = buscar.ProveedorSeleccionado.apellido;
                tele1.Text = buscar.ProveedorSeleccionado.telefono1;
                tele2.Text = buscar.ProveedorSeleccionado.telefono2;
                direc.Text = buscar.ProveedorSeleccionado.direccion;
                email.Text = buscar.ProveedorSeleccionado.email;




            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
  
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            ////////Esta parte es para validar que no se almacenen campos en vacio.
            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(tele1.Text) || string.IsNullOrWhiteSpace(tele2.Text) || string.IsNullOrWhiteSpace(direc.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(apellido.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                Proveedores pProveedor = new Proveedores();

                pProveedor.cod_proveedor = Convert.ToInt16(codigo.Text.Trim());
                pProveedor.nombre = nombre.Text.Trim();
                pProveedor.apellido = apellido.Text.Trim();
                pProveedor.telefono1 = tele1.Text.Trim();
                pProveedor.telefono2 = tele2.Text.Trim();
                pProveedor.direccion = direc.Text.Trim();
                pProveedor.email = email.Text.Trim();
                pProveedor.cod_proveedor = ProveedorActual.cod_proveedor;

                if (ProveedoresDal.Actualizar(pProveedor) > 0)
                {
                    MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /////Volver habilitar la caja de texto.
                    codigo.Enabled = true;



                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}

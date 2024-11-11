using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Proveedores
    {
        // Declarar variables get/set

        public int cod_proveedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }

        public Proveedores() { }
        public void DataSource() { }

        public Proveedores(int pcod_proveedor, string pnombre, string papellido, string ptelefono1, string ptelefono2, string pdireccion, string pemail)
        {

            this.cod_proveedor = pcod_proveedor;
            this.nombre = pnombre;
            this.apellido = papellido;
            this.telefono1 = ptelefono1;
            this.telefono2 = ptelefono2;
            this.direccion = pdireccion;
            this.email = pemail;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using MySql.Data.MySqlClient;




namespace Inventario
{
    public class ProveedoresDal
    {

        public static int Agregar(Proveedores pProveedor)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into proveedor (cod_proveedor ,nombre, telefono1,telefono2,direccion,email, apellido) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}')",
                pProveedor.cod_proveedor, pProveedor.nombre, pProveedor.telefono1, pProveedor.telefono2, pProveedor.direccion, pProveedor.email, pProveedor.apellido), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;


        }



        public static List<Proveedores> Buscar(string pnombre, string papellido)
        {
            List<Proveedores> _lista = new List<Proveedores>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM proveedor  where nombre ='{0}' and apellido='{1}' ", pnombre, papellido), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedores pProveedor = new Proveedores();

                pProveedor.cod_proveedor = _reader.GetInt16(0);
                pProveedor.nombre = _reader.GetString(1);
                pProveedor.telefono1 = _reader.GetString(2);
                pProveedor.telefono2 = _reader.GetString(3);
                pProveedor.direccion = _reader.GetString(4);
                pProveedor.email = _reader.GetString(5);
                pProveedor.apellido = _reader.GetString(6);
                _lista.Add(pProveedor);

            }

            return _lista;
        }




        public static List<Proveedores> Buscar2()
        {
            List<Proveedores> _lista = new List<Proveedores>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT * FROM proveedor"), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedores pProveedor = new Proveedores();
                pProveedor.cod_proveedor = _reader.GetInt16(0);
                pProveedor.nombre = _reader.GetString(1);
                pProveedor.telefono1 = _reader.GetString(2);
                pProveedor.telefono2 = _reader.GetString(3);
                pProveedor.direccion = _reader.GetString(4);
                pProveedor.email = _reader.GetString(5);
                pProveedor.apellido = _reader.GetString(6);

                _lista.Add(pProveedor);


            }

            return _lista;
        }




        public static Proveedores ObtenerProveedor(int pcod_proveedor)
        {
            Proveedores pProveedor = new Proveedores();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM proveedor where cod_proveedor={0}", pcod_proveedor), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pProveedor.cod_proveedor = _reader.GetInt16(0);
                pProveedor.nombre = _reader.GetString(1);
                pProveedor.telefono1 = _reader.GetString(2);
                pProveedor.telefono2 = _reader.GetString(3);
                pProveedor.direccion = _reader.GetString(4);
                pProveedor.email = _reader.GetString(5);
                pProveedor.apellido = _reader.GetString(6);

            }

            conexion.Close();
            return pProveedor;

        }


        public static int Actualizar(Proveedores pProveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update proveedor set nombre='{1}', telefono1='{2}', telefono2='{3}', direccion='{4}', email='{5}', apellido='{6}' where cod_proveedor='{0}'",
                pProveedor.cod_proveedor, pProveedor.nombre, pProveedor.telefono1, pProveedor.telefono2, pProveedor.direccion, pProveedor.email, pProveedor.apellido), conexion);


            retorno = comando.ExecuteNonQuery(); 
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(Proveedores pProveedor)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM proveedor where cod_proveedor='{0}'",
                pProveedor.cod_proveedor, pProveedor.nombre, pProveedor.telefono1, pProveedor.telefono2, pProveedor.direccion, pProveedor.email), conexion);


            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }



    }
}

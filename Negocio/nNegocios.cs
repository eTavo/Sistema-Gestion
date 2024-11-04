using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nArticulos
    {
        public void guardar(string articulo, string proveedor, float precioVenta, float precioCompra, int cantidad)
        {
            // Hago las validaciones

            // Asigno al objeto los datos de la capa de presentacion
            eArticulos nuevoArticulos = new eArticulos();
            nuevoArticulos.Articulo = articulo;
            nuevoArticulos.Cantidad = cantidad;
            nuevoArticulos.Proveedor = proveedor;
            nuevoArticulos.precioVenta = precioVenta;
            nuevoArticulos.precioCompra = precioCompra;

            dArticulos nuevoDato = new dArticulos();
            nuevoDato.guardarArt(nuevoArticulos);
        }
    }

    public class nRegistroUsuarios
    {
        public void guardar(string nombre, string apellido, string email, string pass)
        {
            // Hago las validaciones

            // Asigno al objeto los datos de la capa de presentacion
            eRegistroUsuario usuario = new eRegistroUsuario();
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Email = email;
            usuario.Pass = pass;

            // Guardo los datos del objeto en mi capa de datos
            dRegistroUsuarios nuevoUser = new dRegistroUsuarios();
            nuevoUser.guardarUser(usuario);
        }

        public List<eRegistroUsuario> obtener()
        {
            dRegistroUsuarios user = new dRegistroUsuarios();
            return user.obtener();
        }

        public void eliminar()
        {
            dRegistroUsuarios datos = new dRegistroUsuarios();
            datos.borrarUser();
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dRegistroUsuarios : eRegistroUsuario
    {
        private static List<eRegistroUsuario> datosUsuarios;

        public dRegistroUsuarios()
        {
            if (datosUsuarios == null)
                datosUsuarios = new List<eRegistroUsuario>();
        }

        public void guardarUser(eRegistroUsuario user)
        {
            datosUsuarios.Add(user);
        }

        public void borrarUser()
        {
            datosUsuarios = new List<eRegistroUsuario>();
        }

        public List<eRegistroUsuario> obtener()
        {
            return datosUsuarios;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Usuario
    {
        public static E_Usuario Login(string strUsuario, string strPassword)
        {
            return D_Usuario.Login(strUsuario, strPassword);
        }
    }
}

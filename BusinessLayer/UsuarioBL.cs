using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class UsuarioBL
    {
        public static DataTable VerificarRutPass(string rutUsuario, string Pass)
        {
            return UsuarioDALC.Instance().VerificarRutPass(rutUsuario, Pass);
        }
    }
}

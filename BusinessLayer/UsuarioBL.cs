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
        public static DataTable VerificarRutPass(string Usser, string Pass)
        {
            return UsuarioDALC.Instance().VerificarRutPass(Usser, Pass);
        }
    }
}

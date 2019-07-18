using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        private static Usuario oInstance;

        protected Usuario()
        {

        }

        public static Usuario Instance()
        {
            if (oInstance == null)
                oInstance = new Usuario();

            return oInstance;
        }

        public string rutUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Area { get; set; }
        public string Usser { get; set; }
        public string Pass { get; set; }
        public int idTipo { get; set; }
        public int idArea { get; set; }
        public string Correo { get; set; }
    }
}

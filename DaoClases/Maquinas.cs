using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DaoClases
{
    public class Maquinas
    {
        private int idMaquina;
        private string NombreMaquina;
        private string marca;
        private string color;

        public int IdMaquina
        {
            get
            {
                return idMaquina;
            }

            set
            {
                idMaquina = value;
            }
        }

        public string NombreMaquina1
        {
            get
            {
                return NombreMaquina;
            }

            set
            {
                NombreMaquina = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }
}

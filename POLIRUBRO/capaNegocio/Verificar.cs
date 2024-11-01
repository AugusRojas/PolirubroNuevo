using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIRUBRO
{
    internal class Verificar
    {
        public bool campo_vacios(string variable)
        {
            if (variable != "")
            {
                return false;
            }

            else
            {
                return true;
            }

        }
    }
}

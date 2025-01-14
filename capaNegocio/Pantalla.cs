using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIRUBRO.capaNegocio
{
    public class Pantalla
    {

        public void pantalla(UserControl pantalla, Panel panelcontrolador)
        {
            panelcontrolador.Controls.Clear();
            pantalla.Dock = DockStyle.Fill;
            panelcontrolador.Controls.Add(panelcontrolador);
        }

    }
}

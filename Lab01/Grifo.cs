using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Grifo
    {
        public List<Usuario> Usuarios;

        public virtual void MostrarUsuarios()
        {
            foreach (Usuario usuario in Usuarios)
            {
                usuario.MostrarInformacion();
            }
        }
    }
}

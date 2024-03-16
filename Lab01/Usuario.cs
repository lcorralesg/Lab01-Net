using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Saldo { get; set; }
        public Usuario(string nombre, int saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }
        public virtual void MostrarInformacion()
        {
            string informacion = "Nombre: " + Nombre + " " + "Saldo: " + Saldo;
            Console.WriteLine(informacion);
        }
    }
}

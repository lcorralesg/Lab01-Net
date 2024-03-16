using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Empleado:Usuario
    {
        public double Sueldo { get; set; }
        public Empleado(string nombre, int saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }
        public override void MostrarInformacion()
        {
            string informacion = "Nombre: " + Nombre + " " + "Saldo: " + Saldo + " " +
                "Sueldo: " + Sueldo;
            Console.WriteLine(informacion);
        }
    }
}

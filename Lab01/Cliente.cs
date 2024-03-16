using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }
        public Cliente(string nombre, int saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }
        public override void MostrarInformacion()
        {
            string informacion = "Nombre: " + Nombre + " " + "Saldo: " + Saldo + " " +
                "Litros Cargados: " + LitrosCargados;
            Console.WriteLine(informacion);
        }

    }
}

// See https://aka.ms/new-console-template for more information

using Lab01;
Grifo grifo = new Grifo();
grifo.Usuarios = new List<Usuario>();
while (true)
{
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("1. Mostrar información de usuarios");
    Console.WriteLine("2. Agregar cliente");
    Console.WriteLine("3. Agregar empleado");
    Console.WriteLine("4. Salir");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            grifo.MostrarUsuarios();
            break;
        case "2":
            Console.Write("Ingrese el nombre: ");
            string clinombre = Console.ReadLine();
            Console.Write("Ingrese el saldo: ");
            int clisaldo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los litros cargados: ");
            double litrosCargados = double.Parse(Console.ReadLine());

            Cliente cli = new Cliente(clinombre, clisaldo, litrosCargados);
            grifo.Usuarios.Add(cli);
            break;
        case "3":
            Console.Write("Ingrese el nombre: ");
            string empnombre = Console.ReadLine();
            Console.Write("Ingrese el saldo: ");
            int empsaldo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            Empleado emp = new Empleado(empnombre, empsaldo, sueldo);
            grifo.Usuarios.Add(emp);
            break;
        case "4":
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
            break;
    }
    Console.WriteLine(); // Agrega una línea en blanco para mejorar la presentación
}
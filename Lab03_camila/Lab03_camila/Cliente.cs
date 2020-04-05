using System;
namespace Lab03_camila
{
    class Cliente : Persona

    {
        int puntossupermercado;


        public Cliente(string rut, string nombre, string apellido, string nacimiento, string nacionalidad, int puntossupermercado)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Nacimiento = nacimiento;
            Nacionalidad = nacionalidad;
            Random rnd = new Random();

        }

        public string Realizar_Compra()
        {
            int cantidad;

            cliente1.Realizar_Compra();

            Console.WriteLine(nombre);
           

            DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            Console.Write("Acumula puntos: ");
            Console.WriteLine("\n 1. Si \n 2. No \n");
            puntossupermercado = Convert.ToInt16(Console.ReadLine());
            if (puntossupermercado == 1)
            {
                puntossupermercado += 1;
            }
            Console.Write("Cantidad de productos comprados: ");
            cantidad = Convert.ToInt16(Console.ReadLine());
            int[] productos = new int[cantidad];


        }

        Cliente cliente1 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        Cliente cliente2 = new Cliente("12.789.389-8", "Camila", "Villalobos", "19-03-1988", "chileno", 0);
        Cliente cliente3 = new Cliente("15.490.730-k", "Vicente", "Lira", "03-04-1971", "chileno", 0);
        Cliente cliente4 = new Cliente("10.341.954-5", "Matias", "Olivos", "30-08-1965", "chileno", 0);
        Cliente cliente5 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        Cliente cliente6 = new Cliente("9.298.654-5", "Rebeca", "Perez", "15-10-1940", "chileno", 0);
        Cliente cliente7 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        Cliente cliente8 = new Cliente("19.375.654-8", "Catalina", "Muñoz", "18-06-1998", "chileno", 0);

        public string Nombre { get; }
    }
}

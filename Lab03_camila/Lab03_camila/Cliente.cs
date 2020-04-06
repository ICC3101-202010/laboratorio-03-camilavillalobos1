using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Lab03_camila
{
    class Cliente : Persona

    {
        private int puntossupermercado;
        private List<Producto> clientes;


        public Cliente(string rut, string nombre, string apellido, string nacimiento, string nacionalidad, int puntossupermercado)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Nacimiento = nacimiento;
            Nacionalidad = nacionalidad;
            Random rnd = new Random();

    }

        public bool Realizar_Compra(Producto producto, int cantidad)
        {

            producto.Info_Stock(producto, cantidad);

            if (producto.stock >= cantidad)
            {
                Console.WriteLine("Compra Realizada.");

            }
            else
            {
                Console.WriteLine("No se pudo realizar compra");
            }


            return true;

        }

        //Cliente cliente1 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        //Cliente cliente2 = new Cliente("12.789.389-8", "Camila", "Villalobos", "19-03-1988", "chileno", 0);
        //Cliente cliente3 = new Cliente("15.490.730-k", "Vicente", "Lira", "03-04-1971", "chileno", 0);
        //Cliente cliente4 = new Cliente("10.341.954-5", "Matias", "Olivos", "30-08-1965", "chileno", 0);
        //Cliente cliente5 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        //Cliente cliente6 = new Cliente("9.298.654-5", "Rebeca", "Perez", "15-10-1940", "chileno", 0);
        //Cliente cliente7 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
        //Cliente cliente8 = new Cliente("19.375.654-8", "Catalina", "Muñoz", "18-06-1998", "chileno", 0);

        public string Nombre { get; }
    }
}

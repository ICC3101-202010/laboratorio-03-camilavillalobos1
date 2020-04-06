using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab03_camila
{
    class Program
    {
        public static void Main(string[] args)


        {

            Cliente cliente1 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
            Cliente cliente2 = new Cliente("12.789.389-8", "Camila", "Villalobos", "19-03-1988", "chileno", 0);
            Cliente cliente3 = new Cliente("15.490.730-k", "Vicente", "Lira", "03-04-1971", "chileno", 0);
            Cliente cliente4 = new Cliente("10.341.954-5", "Matias", "Olivos", "30-08-1965", "chileno", 0);
            Cliente cliente5 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
            Cliente cliente6 = new Cliente("9.298.654-5", "Rebeca", "Perez", "15-10-1940", "chileno", 0);
            Cliente cliente7 = new Cliente("12.345.654-8", "Raul", "Quiroga", "09-03-1970", "chileno", 0);
            Cliente cliente8 = new Cliente("19.375.654-8", "Catalina", "Muñoz", "18-06-1998", "chileno", 0);

            Trabajador trabajador1 = new Trabajador("Pedro", "Cajero", 198000, 40);
            Trabajador trabajador2 = new Trabajador("Camila", "Cajero", 198000, 40);
            Trabajador trabajador3 = new Trabajador("Vicente", "Cajero", 300000, 40);
            Trabajador trabajador4 = new Trabajador("Tomas", "Supervisor", 560000, 40);
            Trabajador trabajador5 = new Trabajador("Javiera", "Supervisor", 400000, 40);
            Trabajador trabajador6 = new Trabajador("Benjamin", "Auxiliar", 100000, 40);
            Trabajador trabajador7 = new Trabajador("Belen", "Cajero", 198000, 40);

            Producto papas_fritas = new Producto("papas fritas", 1000, "Lays", 100);
            Producto papas = new Producto("papas", 1300, "malla", 2000);
            Producto galletas = new Producto("galletas", 500, "Lays", 200);
            Producto cloro = new Producto("cloro", 1400, "Clorox", 1000);
            Producto alcoholgel = new Producto("alcohol gel", 2000, "simonds", 10000);
            Producto detergente = new Producto("detergente", 1000, "ariel", 300);
            Producto arroz = new Producto("arroz", 800, "Granel", 1000);

            Console.WriteLine(trabajador1.sueldo);

            Console.ReadLine();

            Console.WriteLine(papas_fritas.stock); // stock de las papas fritas

            Console.ReadLine();

            int variable1 = Convert.ToInt32(Console.ReadLine());

            cliente1.Realizar_Compra(papas_fritas, variable1);

            Console.WriteLine(papas_fritas.stock);

            Console.ReadLine();
            

            Console.WriteLine("hola");
        }
    }
}

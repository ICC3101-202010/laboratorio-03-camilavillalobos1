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

            Producto papas_fritas = new Producto("papas fritas", 1000, "Lays", 100);

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

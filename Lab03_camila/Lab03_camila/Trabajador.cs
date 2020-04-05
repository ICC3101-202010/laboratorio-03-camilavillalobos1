using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_camila
{
    public class Trabajador
    {
        private string Nombre;
        private string Cargo;
        private int Sueldo;
        private string horario;

        public Trabajador(string nombre, string cargo, int sueldo, string horario)

        {
            Nombre = nombre;
            Cargo = cargo;
            Sueldo = sueldo;

            this.horario= horario;
        }

        public int SueldoTrabajador()
        {
            int sueldoNuevo;
            sueldoNuevo = new Random().Next(0, 999999);
            return sueldoNuevo;
        }

        public string HorarioTrabajador() //BUSCAR COMO SE HACE LO DEL HORARIO
        {
            string horario;
            horario = "De 9:00 am a 9:00 pm";

            return horario;
        }
        public string Cambiar_Horario()
        {
            char horario_inicio;
            char horario_fin;

            trabajador1.HorarioTrabajador();

            Console.Write("Horario de inicio: ");
            horario_inicio = Convert.ToChar(Console.ReadLine());
            Console.Write("Horario de fin: ");
            horario_fin = Convert.ToChar(Console.ReadLine());
            horario = horario.Replace(horario[4], horario_inicio);
            horario = horario.Replace(horario[14], horario_fin);
            return horario;
        }

        public int Cambiar_Sueldo(int sueldo)
        {
            Console.Write("Sueldo nuevo: ");
            sueldo  = Convert.ToInt16(Console.ReadLine());
            return sueldo ;
        }

        public string Cambiar_Puesto(string puesto)
        {

            Console.Write("Puesto nuevo: ");
            puesto  = (Console.ReadLine());
            return puesto ;


        }


        Trabajador trabajador1 = new Trabajador("Pedro", "Cajero", 198000, "part time");
        Trabajador trabajador2 = new Trabajador("Camila", "Cajero", 198000, "part time");
        Trabajador trabajador3 = new Trabajador("Vicente", "Cajero", 300000, "full time");
        Trabajador trabajador4 = new Trabajador("Tomas", "Jefe", 560000, "part time");
        Trabajador trabajador5 = new Trabajador("Javiera", "Supervisor", 400000, "part time");
        Trabajador trabajador6 = new Trabajador("Benjamin", "Auxiliar", 100000, "part time");
        Trabajador trabajador7 = new Trabajador("Belen", "Cajero", 198000, "part time");
    }
}

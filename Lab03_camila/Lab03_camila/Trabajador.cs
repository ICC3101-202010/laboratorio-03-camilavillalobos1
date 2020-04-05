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
        private string Horario;

        public Trabajador(string nombre, string cargo, int sueldo, string horario)

        {
            Nombre = nombre;
            Cargo = cargo;
            Sueldo = sueldo;
            Horario = horario;
        }

        public int SueldoTrabajador()
        {
            int sueldoNuevo;
            sueldoNuevo = new Random().Next(0, 999999);
            return sueldoNuevo;
        }

        public string HorarioTrabajador() //BUSCAR COMO SE HACE LO DEL HORARIO
        {
            DateTime date horario
            horario = "De 08:00 a 21:00";

            return horario;
        }
        public string Cambiar_Horario()
        {
            char horario_inicio;
            char horario_fin;

            HorarioTrabajador();
            Console.Write("Horario de inicio: ");
            horario_inicio = Convert.ToChar(Console.ReadLine());
            Console.Write("Horario de fin: ");
            horario_fin = Convert.ToChar(Console.ReadLine());
            horario = horario.Replace(horario[4], horario_inicio);
            horario = horario.Replace(horario[11], horario_fin);
            return horario;
        }

        public int Cambiar_Sueldo()
        {
            int nuevo_sueldo;
            Console.Write("Sueldo nuevo: ");
            nuevo_sueldo = Convert.ToInt16(Console.ReadLine());
            return nuevo_sueldo;
        }

        public string Cambiar_Puesto()
        {
            string nuevo_puesto;
            Console.Write("Puesto nuevo: ");
            nuevo_puesto = (Console.ReadLine());
            return nuevo_puesto;


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

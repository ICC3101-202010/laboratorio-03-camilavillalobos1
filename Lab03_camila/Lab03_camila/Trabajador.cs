using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_camila
{
    public class Trabajador
    {
        private string cargo;
        private int sueldo;
        private string horario;

        public Trabajador(string cargo, int sueldo, string horario)

        {

        }

        public int Sueldo()
        {
            sueldo = new Random().Next(0, 999999);
            return sueldo;
        }

        public string Horario()
        {
            horario = "De 08:00 a 21:00";

            return horario;
        }
        public string Cambiar_Horario()
        {
            char horario_inicio;
            char horario_fin;

            Horario();
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
    }
}

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_camila
{
    public class Trabajador
    {
        private string Nombre;
        private string Apellido;
        private string Cargo;
        private int Sueldo;
        private int horario = 40;


        public Trabajador(string nombre, string apellido, string cargo, int sueldo, int horario)

        {
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Sueldo = sueldo;
            this.horario = horario;

 
        }

        public bool SueldoTrabajadores(string cargo)
        {
            if (cargo == "Cajero")
            {
                Sueldo = 500000;
            }
            if (cargo == "Supervisor")
            {
                Sueldo = 700000;
            }
            if (cargo == "Auxiliar")
            {
                Sueldo = 300000;
            }

            return true;

        }
        
        public bool Cambiar_Horario(Trabajador trabajador, int horario)

        {
            trabajador.horario = horario;

            return true;
        }

        public int Cambiar_Sueldo(Trabajador trabajador, int sueldo)
        {
            trabajador.Sueldo = sueldo;
            return sueldo ;
        }

        public string Cambiar_Puesto(Trabajador trabajador, string cargo)
        {

            trabajador.Cargo  = cargo ;

            return cargo;

        }


        //Trabajador trabajador1 = new Trabajador("Pedro", "Cajero", 198000, 40);
        //Trabajador trabajador2 = new Trabajador("Camila", "Cajero", 198000, 40);
        //Trabajador trabajador3 = new Trabajador("Vicente", "Cajero", 300000, 40);
        //Trabajador trabajador4 = new Trabajador("Tomas", "Supervisor", 560000, 40);
        //Trabajador trabajador5 = new Trabajador("Javiera", "Supervisor", 400000,40);
        //Trabajador trabajador6 = new Trabajador("Benjamin", "Auxiliar", 100000, 40);
        //Trabajador trabajador7 = new Trabajador("Belen", "Cajero", 198000, 40);
        internal bool sueldo;
    }
}

using System;
namespace Lab03_camila
{
    class Cliente : Persona

    {

        public Cliente(string rut, string nombre, string apellido, string nacimiento, string nacionalidad)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Nacimiento = nacimiento;
            Nacionalidad = nacionalidad;
            Random rnd = new Random();

        }

        public string Informacion()
        {
            
        }
    }
}

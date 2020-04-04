using System;
namespace Lab03_camila
{
    public class Persona
    {
        protected string Rut;
        protected string Nombre;
        protected string Apellido;
        protected string Nacimiento;
        protected string Nacionalidad;

        protected string[] nombres = { "Camila", "Vicente" , "Javiera", "Sebastian", "Patricio", "Emilia", "Constanza", "Carla", "Catalina", "Federico"};
        protected string[] apellidos = {"Villalobos", "Perez", "Lira", "Henriquez", "Muñoz", "Bravo", "Lopez" };
        protected string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        protected int[] dias = new int[30];
        protected string[] nacionalidad = { "chileno", "argentino", "cubano", "frances", "italiano", "peruano" };
    }
}

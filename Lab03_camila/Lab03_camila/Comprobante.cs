using System;
namespace Lab03_camila
{
    public class Comprobante
    {
        private DateTime datetime;
        private string nombreCliente;
        private string apellidoCliente;
        private string nombreCajero;
        private string apellidoCajero;
        private string productoComprado;
        private int precioTotal;

        public DateTime DateTime { get; }


        public Comprobante(string nombreCliente, string apellidoCliente, string nombreCajero, string apellidoCajero, string productoComprado, int precioTotal, DateTime datetime)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.nombreCajero = nombreCajero;
            this.apellidoCajero = apellidoCajero;
            this.productoComprado = productoComprado;
            this.precioTotal = precioTotal;
            DateTime = datetime;
        }

        public void Informacion_Comprobante(Comprobante comprobante)
        {
            Console.WriteLine("Nombre Cliente: " + comprobante.nombreCliente);
            Console.WriteLine("Apellido Cliente: " + comprobante.apellidoCliente);
            Console.WriteLine("Nombre Cajero: " + comprobante.nombreCajero);
            Console.WriteLine("Apellido Cajero: " + comprobante.apellidoCajero);
            Console.WriteLine("Producto Comprado: " + comprobante.productoComprado);
            Console.WriteLine("Precio total: " + comprobante.precioTotal);
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        }

    }
}

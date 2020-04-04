using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lab03_camila
{
    public class Producto
    {
        private string nombre_producto;
        private string precio_producto;
        private string marca;
        private int stock;
        private List<Producto> productos;
        int stock_general = 100;

        public Producto(string nombre_producto, string precio_producto, string marca, int stock)
        {
            this.nombre_producto = nombre_producto;
            this.precio_producto = precio_producto;
            this.marca = marca;
            this.stock = stock;
        }
        public int Info_Stock()
        {

            return stock;
        }






        //public List<Producto> Agregar_Producto()
        //{
        //    Console.Write("Nombre del producto: ");
        //    nombre_producto = Console.ReadLine();
        //    Console.Write("Marca del producto: ");
        //    marca = Console.ReadLine();
        //    Console.Write("Precio del producto: ");
        //    precio_producto = Console.ReadLine();
        //    return productos;


        }
    }
}

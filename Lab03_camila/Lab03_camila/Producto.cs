﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lab03_camila
{
    public class Producto 
    {
        private const bool V = true;
        private const bool F = false;
        private string nombre_producto;
        private int precio_producto;
        private string marca;
        public int stock;
        private List<Producto> productos;

        public Producto(string nombre_producto, int precio_producto, string marca, int stock)
        {
            this.nombre_producto = nombre_producto;
            this.precio_producto = precio_producto;
            this.marca = marca;
            this.stock = stock;
        }
        public bool Info_Stock(Producto nombre_producto, int cant)
        {

            nombre_producto.stock -= cant;

            if (nombre_producto.stock <= 0)
            {
                nombre_producto.stock = 0;
                Console.WriteLine("No hay stock total del producto");

                return F;
            }

            return V;
        }

        public void Productos_Disponibles(string nombre_producto, string marca, int precio_producto, int stock)

        {
            Console.WriteLine("Nombre producto: ", nombre_producto + "Marca: ", marca + "Precio; ", precio_producto + "Stock Disponible", stock);
        }



        //Producto papas_fritas = new Producto("papas fritas", 1000, "Lays", 100);
        //Producto papas = new Producto("papas", 1300, "malla", 2000);
        //Producto galletas = new Producto("galletas", 500, "Lays", 200);
        //Producto cloro = new Producto("cloro", 1400, "Clorox", 1000);
        //Producto alcoholgel = new Producto("alcohol gel", 2000, "simonds", 10000);
        //Producto detergente = new Producto("detergente", 1000, "ariel", 300);
        //Producto arroz = new Producto("arroz", 800, "Granel", 1000);
    }
}

using APP;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static PedidoService servicio=new PedidoService();
       
       
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL" +
                    "\n1. Registrar nuevo pedido" +
                    "\n2. Listar todos los pedidos" +
                    "\n0. salir" +
                    "\n Opcion:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        agregar();
                        break;
                    case 2:
                        mostrar();
                        break;
                    default:
                        break;
                }



            } while (opcion != 0);

        }

        private static void agregar()
        {
            string estudiante, libro;
            Console.Clear();
            Console.WriteLine("AGREGAR" +
                "\n\nDigite el nombre del estudiante: ");
            estudiante=Console.ReadLine();
            Console.WriteLine("Digite el nombre del libro");
            libro = Console.ReadLine();
            string mensaje = servicio.Agregar(estudiante, libro);
            Console.WriteLine(mensaje);
        }

        private static void mostrar()
        {
            Console.Clear();
            servicio=new PedidoService();
            List<Pedido> lista = servicio.ObtenerTodas();
            Console.WriteLine("ID\t|ESTUDIANTE\t|LIBRO\t|FECHA");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Id}\t{item.Estudiante}\t{item.Libro}\t{item.Fecha}\t");
            }
            Console.ReadKey();
        }
    }
}

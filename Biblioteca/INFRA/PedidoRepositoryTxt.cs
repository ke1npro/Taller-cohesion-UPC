using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace INFRA
{
    public class PedidoRepositoryTxt : ICrud<Pedido>
        
    {
        string ruta = "Pedidos.txt";
        public bool Actualizar(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Pedido pedido)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine($"{pedido.Id}|{pedido.Estudiante}|{pedido.Libro}|{pedido.Fecha}");
                escritor.Close();


                return $"se ha agregado el pedido {pedido.Id} exitosamente";
            } catch (Exception e)
            {
                return $"Hubo un error al guardar datos  " + e;
            }

            
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ObtenerTodas()
        {
            StreamReader lector = new StreamReader(ruta);
            List<Pedido> listaPedidos = new List<Pedido>();
            try
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();

                    listaPedidos.Add(Mapear(linea));
                }
                lector.Close();
                return listaPedidos;

            }
            catch (Exception e)
            {
                return null;
            }

            
        }



        private Pedido Mapear(string linea)
        {
            Pedido pedido = new Pedido();
            var aux = linea.Split('|');

            pedido.Id = int.Parse(aux[0]);

            pedido.Estudiante = aux[1];
            pedido.Libro = aux[2];
            pedido.Fecha = System.DateTime.Parse(aux[3]);


            return pedido;
        }




    }
}

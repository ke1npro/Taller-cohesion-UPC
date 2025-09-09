using ENTITY;
using INFRA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{

    public class PedidoService
    {

        List<Pedido> listaPedidos;
        PedidoRepositoryTxt pedidoRepository;

        public PedidoService()
        {
            pedidoRepository = new PedidoRepositoryTxt();
            listaPedidos = pedidoRepository.ObtenerTodas();
        }

        // Crear
        public string Agregar(string Estudiante, string libro)
        {

            if ((Estudiante == null) || (libro == null)||(Estudiante.Trim().Length==0)|| (libro.Trim().Length == 0))
            {
                return $"Error de campos vacios";

            }
            else
            {

                try
                {
                    
                    int cantidadRegistros = 0;
                    
                    foreach (var item in listaPedidos)
                    {
                        cantidadRegistros++;
                    }
                    DateTime fecha = DateTime.UtcNow;
                    string mensaje = pedidoRepository.Agregar(new Pedido(cantidadRegistros,Estudiante,libro,fecha));
                    return mensaje;
                }
                catch (Exception e)
                {
                    return $"Hubo un error al registrar datos" + e;
                }

            }
        }

        

        // Leer 
        public List<Pedido> ObtenerTodas()
        {
            
            return listaPedidos;
        }

        
    }
}

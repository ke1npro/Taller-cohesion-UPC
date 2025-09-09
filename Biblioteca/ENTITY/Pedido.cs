using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Pedido
    {
        public Pedido()
        {
        }

        public int Id { get; set; }
        public string Estudiante { get; set; }
        public string Libro { get; set; }
        public DateTime Fecha { get; set; }

        public Pedido(int id,string estu,string libro,DateTime fecha)
        {
            Id = id;
            Estudiante = estu;
            Libro = libro;
            Fecha = fecha;
        }


    }
}
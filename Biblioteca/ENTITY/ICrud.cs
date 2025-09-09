using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface ICrud<T>
    {
        string Agregar(T entity);
        T ObtenerPorId(int id);
        List<T> ObtenerTodas();
        bool Actualizar(T entity);
        bool Eliminar(int id);
    }
}

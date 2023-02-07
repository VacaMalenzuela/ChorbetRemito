using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dominio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> Lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("select ID, Codigo, Nombre, PrecioUni from Productos");
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {
                Producto aux = new Producto();

                aux.ID = (int)datos.Lector["Id"];
                if (!(datos.Lector["Codigo"] is DBNull))
                    aux.codigo = (string)datos.Lector["Codigo"];
                if (!(datos.Lector["Nombre"] is DBNull))
                    aux.nombre = (string)datos.Lector["Nombre"];
                if (!(datos.Lector["PrecioUni"] is DBNull))
                    aux.precio = (float)datos.Lector["PrecioUni"];

                Lista.Add(aux);
            }

            return Lista;
        }
    }
}

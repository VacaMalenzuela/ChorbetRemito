using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dominio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> Lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("select c.id, c.nombre, encargado, telefono, direccion, d.nombre as Departamento from clientes c inner join departamentos d on d.id = c.iddepartamento where activo = 1");
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {
                Cliente aux = new Cliente();

                aux.Id = (int)datos.Lector["id"];
                if (!(datos.Lector["c.nombre"] is DBNull))
                    aux.Nombre = (string)datos.Lector["c.nombre"];
                if (!(datos.Lector["encargado"] is DBNull))
                    aux.Encargado = (string)datos.Lector["encargado"];
                if (!(datos.Lector["telefono"] is DBNull))
                    aux.Telefono = (string)datos.Lector["telefono"];
                if (!(datos.Lector["direccion"] is DBNull))
                    aux.Direccion = (string)datos.Lector["direccion"];
                if (!(datos.Lector["d.nombre"] is DBNull))
                    aux.Departamento = (string)datos.Lector["d.nombre"];

                Lista.Add(aux);
            }

            return Lista;
        }

        public List<Cliente> listarNombres()
        {
            List<Cliente> Lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            datos.setConsulta("select id, Nombre from Clientes");
            datos.EjecutarLectura();

            while (datos.Lector.Read())
            {
                Cliente aux = new Cliente();

                aux.Id = (int)datos.Lector["id"];
                if (!(datos.Lector["nombre"] is DBNull))
                    aux.Nombre = (string)datos.Lector["nombre"];

                Lista.Add(aux);
            }

            return Lista;
        }
    }
}

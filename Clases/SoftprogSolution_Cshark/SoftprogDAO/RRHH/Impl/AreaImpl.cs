using SoftprogDAO.RRHH.DAO;
using SoftprogDomain.RRHH;
using System;
using System.Collections.Generic;
using System.Text;
using SoftprogDBManager;

using MySql.Data.MySqlClient;

namespace SoftprogDAO.RRHH.Impl
{
    public class AreaImpl : AreaDAO
    {
        public Area BuscarPorId(int idObjeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idObjeto)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Area area)
        {
            int resultado = 0;
            try
            {
                using MySqlConnection con = DBManager.Instance.Connection; //el using es para que el objeto se libere, para no 
                using MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO area(nombre,activa) VALUES('"+ area.Nombre+"',1)";
                resultado = cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                Console.WriteLine("Error al insertar un area: " + ex.Message);
            }

            return resultado;
        }

        public List<Area> ListarTodos()
        {
            List<Area>? areas = null;
            using MySqlConnection con =
                    DBManager.Instance.Connection;
            using MySqlCommand cmd =
                    con.CreateCommand();
            cmd.CommandText = "SELECT id_area, " +
                "nombre, activa FROM area WHERE activa = 1";
            using MySqlDataReader lector
                = cmd.ExecuteReader();
            while (lector.Read())
            {
                if (areas == null) areas = new List<Area>();
                Area area = new Area();
                area.IdArea = lector.GetInt32("id_area");
                area.Nombre = lector.GetString("nombre");
                area.Activo = true;
                areas.Add(area);
            }
            return areas;
        }

        public int Modificar(Area objeto)
        {
            throw new NotImplementedException();
        }
    }
}

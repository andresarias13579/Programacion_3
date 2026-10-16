using System;
using System.Collections.Generic;
using System.Text;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDBManager;
using SpotipucpDomain.Clases;
using MySql.Data.MySqlClient;
using System.Data;

namespace SpotipucpDAO.Clases.Impl
{
    public class UsuarioImpl : UsuarioDAO
    {
        public int insertar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> listarTodo()
        {
            using MySqlConnection con = DBManager.Instance.Connection;
            using MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listar_usuarios";
            using MySqlDataReader lector = cmd.ExecuteReader();
            List<Usuario> listaUsuario = new List<Usuario>();
            while (lector.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = lector.GetInt32("id");
                usuario.Codigo = lector.GetString("codigo");
                usuario.Nombre = lector.GetString("nombre");
                usuario.Correo = lector.GetString("correo");
                listaUsuario.Add(usuario);
            }
            return listaUsuario;
        }
    }
}

using SpotipucpBO.Clases.BOI;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDAO.Clases.Impl;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.Clases.BO
{
    public class UsuarioBOImpl : IUsuarioBO
    {
        private UsuarioDAO daoUsuario;

        public UsuarioBOImpl()
        {
            daoUsuario = new UsuarioImpl();
        }

        public int Insertar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> listarTodos()
        {
            return daoUsuario.listarTodo();
        }

    }
}

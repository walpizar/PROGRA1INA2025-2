using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService : IGenerica<clsUsuario>
    {
        //declaro instacia de DAO, privado y solo lectura para que no se modifique
        private readonly LoginDao _loginDao = new LoginDao();

        public LoginService() 
        {

        }


        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsUsuario> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void crear(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }
    }
}

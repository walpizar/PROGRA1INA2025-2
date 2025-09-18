using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Services
{
    public class donanteService : IGenerica<clsDonante>
    {
        //inicio DAO
        DAO.donanteDAO donanteDAO;

        public donanteService()
        {
            donanteDAO = new donanteDAO();
        }

        public clsDonante consultarPorID(string id)
        {
            return donanteDAO.consultarPorID(id);
        }

        public clsDonante consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonante> consultarTodos()
        {
            return donanteDAO.consultarTodos();
        }

        public void crear(clsDonante entidad)
        {
            //valido datos
            if (string.IsNullOrEmpty(entidad.personaId.ToString()))
            {
                throw new ArgumentException("El ID de la persona no puede estar vacío ");
            }


        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDonante entidad)
        {
            throw new NotImplementedException();
        }
    }
}

using Common.Exceptions;
using DAO;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VisitasService
    {
        private readonly VisitasDAO _VisitasDao;


        public VisitasService()
        {
            _VisitasDao = new VisitasDAO();
        }

        public void crear(clsVisitasDomiciliares entidad)
        {
            _VisitasDao.crear(entidad);
        }

        public List<clsVisitasDomiciliares> consultarTodos()
        {
            return _VisitasDao.consultarTodos();
        }
    }
}

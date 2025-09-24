using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AsigActivoDao : IGenerica<clsAsignacionActivosPaciente>
    {
        //creo instanciA para el contex de la base de datos
        private readonly dbContextINA _context;

        //constructor
        public AsigActivoDao()
        {
            //aqui lo instancio
            _context = new dbContextINA();
        }


        public void crear(clsAsignacionActivosPaciente asigActivo)
        {
            //asigno la fecha de creacion y usuario de creacion y estado
            estado = true; //activo por defecto
            asigActivo.fecha_crea = DateTime.Now;//asigno la fecha actual
            asigActivo.usuario_crea = "Jumira"; //X mientras luego lo cambio por el usuario logueado

            //aqui llamo al metodo crear del dao
            _context.asignacionActivosPaciente.Add(asigActivo);
            _context.SaveChanges();
        }


        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public clsAsignacionActivosPaciente consultarPorID(int id)
        {
            return _context.asignacionActivosPaciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.paciente)//esto es para traer los datos de la tabla pacviente que esta relacionada con la asiganacion
                .FirstOrDefault(a => a.idPaciente.Equals(id));
        }

        public clsAsignacionActivosPaciente consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsAsignacionActivosPaciente consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsAsignacionActivosPaciente> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsAsignacionActivosPaciente entidad)
        {
            throw new NotImplementedException();
        }



    }
}

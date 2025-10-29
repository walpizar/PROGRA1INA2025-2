<<<<<<< HEAD
﻿using Entities;
=======
﻿using Common.Interfaces;
using DAO;
using Entities;
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DAO;
using Common.Interfaces;


namespace Services
{
    public class PuestoService:IGenerica<clsPuestos>

=======

namespace Services
{
    public class PuestoService : IGenerica<clsPuestos>
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
    {
        private readonly PuestosDao _dao = new PuestosDao();
        private DepartamentosService _depService = new DepartamentosService();


        public clsPuestos consultarPorID(int id)
        {
<<<<<<< HEAD
            return _dao.consultarPorID(id);
=======
           return _dao.consultarPorID(id);
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
        }

        public clsPuestos consultarPorNombre(string nombre)
        {
            return _dao.consultarPorNombre(nombre);
        }

        public List<clsPuestos> consultarTodos()
        {
            return _dao.consultarTodos();
        }

        public void crear(clsPuestos p)
        {
            ValidarCamposComunes(p);

            if (string.IsNullOrWhiteSpace(p.codigo))
                throw new Exception("El código del puesto es obligatorio");

            // Validación de código único
            var codigoDup = _dao.consultarTodos()
                        .Any(x => x.codigo.Trim().ToUpper() == p.codigo.Trim().ToUpper());
            if (codigoDup)
                throw new Exception("Ya existe un puesto con ese código.");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del puesto es obligatorio");

            // Validar que el nombre no esté duplicado en el MISMO departamento (solo activos)
            if (p.Estado)
            {
                var nombreDup = _dao.consultarTodos()
                                    .Any(x => x.idDepartamento == p.idDepartamento &&
                                              x.Estado == true &&
                                              x.Nombre.Trim().ToUpper() == p.Nombre.Trim().ToUpper());
                if (nombreDup)
                    throw new Exception("Ya existe un puesto ACTIVO con ese nombre en este departamento.");
            }

            p.fecha_crea = DateTime.UtcNow;
            p.usuario_crea = string.IsNullOrWhiteSpace(p.usuario_crea) ? "system" : p.usuario_crea;

            _dao.crear(p);
        }

        public void eliminar(int id)
        {
            if (_dao.consultarPorID(id) == null)
                throw new Exception("El puesto no existe");
        }

        public void inactivar(int id, string motivo, string usuario)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new Exception("Debe ingresar un motivo de inactivación.");

            var p = _dao.consultarPorID(id);
            if (p == null) throw new Exception("El puesto no existe.");
            if (!p.Estado) throw new Exception("El puesto ya está inactivo.");

            p.Inactivar(motivo.Trim(), string.IsNullOrWhiteSpace(usuario) ? "system" : usuario);

            // auditoría
            p.fecha_ult_mod = DateTime.Now;
            p.usuario_ult_mod = string.IsNullOrWhiteSpace(usuario) ? "system" : usuario;

            _dao.modificar(p);
        }

        public void reactivar(int id, string usuario)
        {
            var p = _dao.consultarPorID(id);
            if (p == null) throw new Exception("El puesto no existe.");
            if (p.Estado) throw new Exception("El puesto ya está activo.");

            p.Reactivar(string.IsNullOrWhiteSpace(usuario) ? "system" : usuario);

            p.motivoInactivo = "";
            p.fecha_ult_mod = DateTime.Now;
            p.usuario_ult_mod = string.IsNullOrWhiteSpace(usuario) ? "system" : usuario;

            _dao.modificar(p);
        }

        public void modificar(clsPuestos p)
        {
            ValidarCamposComunes(p);

            if (_dao.consultarPorID(p.idPuesto) == null)
                throw new Exception("El puesto no existe");

            if (string.IsNullOrWhiteSpace(p.codigo))
                throw new Exception("El código del puesto es obligatorio");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre es obligatorio");

            // Validación de código único
            var codigoDup = _dao.consultarTodos()
                    .Any(x => x.idPuesto != p.idPuesto &&
                              x.codigo.Trim().ToUpper() == p.codigo.Trim().ToUpper());
            if (codigoDup)
                throw new Exception("Ya existe un puesto con ese código.");

            // Validar nombre único en el mismo departamento (solo activos)
            if (p.Estado)
            {
                var nombreDup = _dao.consultarTodos()
                                    .Any(x => x.idPuesto != p.idPuesto &&
                                              x.idDepartamento == p.idDepartamento &&
                                              x.Estado == true &&
                                              x.Nombre.Trim().ToUpper() == p.Nombre.Trim().ToUpper());
                if (nombreDup)
                    throw new Exception("Ya existe un puesto ACTIVO con ese nombre en este departamento.");
            }

            p.fecha_ult_mod = DateTime.Now;
            p.usuario_ult_mod = string.IsNullOrWhiteSpace(p.usuario_ult_mod) ? "system" : p.usuario_ult_mod;

            _dao.modificar(p);
        }

        private static void ValidarCamposComunes(clsPuestos p)
        {
            if (string.IsNullOrWhiteSpace(p.codigo) || p.codigo.Length > 20)
                throw new Exception("Código es obligatorio y ≤ 20.");
            if (string.IsNullOrWhiteSpace(p.Nombre) || p.Nombre.Length > 100)
                throw new Exception("Nombre es obligatorio y ≤ 100.");
            if (p.descripcion != null && p.descripcion.Length > 250)
                throw new Exception("La descripción debe ser ≤ 250.");
            // Motivo: obligatorio al INACTIVAR, prohibido cuando ACTIVO aqui solo se ve que si esta activo no cargue el motivo
            if (p.Estado && !string.IsNullOrWhiteSpace(p.motivoInactivo))
                throw new Exception("No debe indicar motivo cuando el puesto está activo.");
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsPuestos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD





=======
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
    }
}

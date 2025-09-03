using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbRolPermiso")]
    public class clsRolPermiso
    {
        //llave primaria compuesta
        public int idRol { get; set; }
        public int idPermiso { get; set; }

        public bool estado { get; set; }

        //relaciones con clsRol y clsPermisos
        public clsRol Rol { get; set; }
        public clsPermisos Permiso { get; set; }

        //constructores
        public clsRolPermiso() { }

        public clsRolPermiso(int idRol, int idPermiso, bool estado)
        {
            this.idRol = idRol;
            this.idPermiso = idPermiso;
            this.estado = estado;
        }


        public override string ToString()
        {
            return $"idRol: {idRol}, idPermiso: {idPermiso}, estado: {estado}";
        }
    }
}

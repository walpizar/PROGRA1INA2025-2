using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMantenimientoRoles : Form
    {
        private readonly SeguridadService _Service;//ACCESO A SERVICE

        List<clsRol> lista;
        List<clsModulo> listaModulos;
        List<clsPermiso> listaPermisos;

        public frmMantenimientoRoles()
        {
            InitializeComponent();//INICIALIZACION DEL ACCESO A SERVICE
            _Service = new SeguridadService();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoRoles_Load(object sender, EventArgs e)
        {
            cargarRolesBox();
            cargarModulosBox();

            this.lista = _Service.consultarRoles(); //TRAIGO LOS ROLES ACTUALIZADS DEL DB
            cargarListaRoles(this.lista);

            this.listaModulos = _Service.consultarModulos();    
            cargarListaModulos(this.listaModulos);

            this.listaPermisos = _Service.consultarPermisos();
            cargarListaPermisos(this.listaPermisos);
        }

        public void cargarRolesBox()//COMBO BOXROLES
        {
            try
            {
                var listaRoles = _Service.consultarRoles();
                comboBox1.DataSource = listaRoles;
                comboBox1.DisplayMember = "nombreRol";
                comboBox1.ValueMember = "idRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de roles: " + ex.Message);
            }
        }

        private void cargarModulosBox()//COMBO BOX MODULO
        {
            try
            {
                var listaModulos = _Service.consultarModulos();
                comboBox2.DataSource = listaModulos;
                comboBox2.DisplayMember = "nombreModulo";
                comboBox2.ValueMember = "idModulo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de módulos: " + ex.Message);
            }
        }

        public void cargarListaRoles(List<clsRol> lista)//MOSTRAR LISTA DE ROLES
        {

            listView1.Items.Clear();//EVITAR CELDAS VACIAS Y DATOS REPEDITOS

            foreach (clsRol roles in lista)//CICLO QUE MUESTRA CADA ROL DE LA DB
            {
                ListViewItem item = new ListViewItem(roles.nombreRol);
                item.SubItems.Add(roles.descripcionRol);
                listView1.Items.Add(item);
                item.Tag = roles.idRol;
            }
        }

        public void cargarListaModulos(List<clsModulo> listaModulos)//MOSTRAR LISTA DE ROLES
        {

            listView2.Items.Clear();//EVITAR CELDAS VACIAS Y DATOS REPEDITOS

            foreach (clsModulo modul in listaModulos)//CICLO QUE MUESTRA CADA ROL DE LA DB
            {
                ListViewItem item = new ListViewItem(modul.nombreModulo);
                item.SubItems.Add(modul.descripcionModulo);
                listView2.Items.Add(item);
                item.Tag = modul.idModulo;
            }
        }

        public void cargarListaPermisos(List<clsPermiso> listaPermisos)//MOSTRAR LISTA DE PERMISOS
        {

            listView3.Items.Clear();//EVITAR CELDAS VACIAS Y DATOS REPEDITOS

            foreach (clsPermiso pe in listaPermisos)//CICLO QUE MUESTRA CADA ROL DE LA DB
            {
                ListViewItem item = new ListViewItem(pe.rol.nombreRol);
                item.SubItems.Add(pe.modulo.nombreModulo);
                item.SubItems.Add(pe.consultar ? "    ✔" : "     ✘");
                item.SubItems.Add(pe.crear ? "    ✔" : "     ✘");
                item.SubItems.Add(pe.editar ? "    ✔" : "     ✘");
                item.SubItems.Add(pe.eliminar ? "    ✔" : "     ✘");

                listView3.Items.Add(item);
            }
        }

        private void buttonCrearRol_Click(object sender, EventArgs e)//CREAR ROL
        {
            try
            {
                clsRol roool = new clsRol();//CREO UN ESPACIO PARA NUEVO ROL

                roool.nombreRol = textBoxNombreRol.Text;//LE DOY UN NOMBRE Y DESCRIPCION
                roool.descripcionRol = richTextBoxDescripcionRol.Text;

                _Service.crearRol(roool);//LE MANDO ROOL A SERVICE PARA CEARLO
                MessageBox.Show("ROL CREADO CORRECTAMENTE");

                //LIMPIAR CAMPOS
                textBoxNombreRol.Clear();
                richTextBoxDescripcionRol.Clear();

                cargarListaRoles(_Service.consultarRoles());//ACTUALIZAR LISTA DE ROLES
                cargarRolesBox();

            }
            catch (Exception ex)//EXCEPCION DESCONOCIDA
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCrearPermiso_Click(object sender, EventArgs e)//CREAR PERMISO
        {
            try
            {//CONSULTAR SI EXISTE EN PERMISOS
                int idRol = Convert.ToInt32(comboBox1.SelectedValue);
                int idModulo = Convert.ToInt32(comboBox2.SelectedValue);
                string nombreRol = comboBox1.DisplayMember;
                string nombreModulo = comboBox2.DisplayMember;

                var permiso = _Service.consultarPermi(idModulo, idRol);

                if (permiso != null)//SI EXISTE
                {
                    DialogResult result = MessageBox.Show("SEGURO DE QUE QUIERE GUARDAR CAMBIOS?", "CAMBIO REALIZADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!chkConsultar.Checked && !chkEditar.Checked && !chkEliminar.Checked && !chkCrear.Checked)
                        {//SI EXISTE Y SE GUARDA VACIO SE ELIMINA DEL DB
                            MessageBox.Show($"PERMISO MODIFICADO, EL ROL {comboBox1.Text} YA NO TIENE PERMISO SOBRE EL MODULO {comboBox2.Text}");
                            _Service.eliminarPermiso(permiso);//PARA ELIMINAR LLAVE COMPUESTA
                            cargarListaPermisos(_Service.consultarPermisos());
                        }
                        else
                        {//SI EXISTE SE MODIFICA  
                            permiso.consultar = chkConsultar.Checked;
                            permiso.crear = chkCrear.Checked;
                            permiso.editar = chkEditar.Checked;
                            permiso.eliminar = chkEliminar.Checked;
                            _Service.modificarPermiso(permiso);
                            cargarListaPermisos(_Service.consultarPermisos());
                            MessageBox.Show("PERMISO MODIFICADO");
                        }
                    }
                }
                else
                {//SI NO EXISTE SE CREA
                    if (!chkConsultar.Checked && !chkEditar.Checked && !chkEliminar.Checked && !chkCrear.Checked)
                    {
                        MessageBox.Show("MARQUE ALGUN CHECK");
                    }
                    else
                    {
                        var permi = new clsPermiso();
                        {
                            permi.idRol = Convert.ToInt32(comboBox1.SelectedValue ?? 0);
                            permi.idModulo = Convert.ToInt32(comboBox2.SelectedValue ?? 0);
                            permi.consultar = chkConsultar.Checked;
                            permi.crear = chkCrear.Checked;
                            permi.editar = chkEditar.Checked;
                            permi.eliminar = chkEliminar.Checked;
                        }
                        _Service.crearPer(permi);//SE CREA Y SE GUARDA
                        cargarListaPermisos(_Service.consultarPermisos());
                        MessageBox.Show($" PERMISO DEL ROL {comboBox1.Text} SOBRE EL MODULO {comboBox2.Text} CREADO CORRECTAMENTAMENTE");
                    }
                }
            }
            catch (Exception ex)//EXCEPCION DESCONOCIDA
            {
                MessageBox.Show("Error desconocido. Contante con el administrador.");
            }
        }

        private void buscarPermiso_Click(object sender, EventArgs e)//BUSCAR Y MOSTRAR PERMISO
        {
            int idRol = Convert.ToInt32(comboBox1.SelectedValue);
            int idModulo = Convert.ToInt32(comboBox2.SelectedValue);
            var permiso = _Service.consultarPermi(idModulo, idRol); ;//SE LO MANDO A SERVICE PARA VERIFICAR SI EXISTE

            if (permiso != null)//SII EXISTE MOSTRAR PERMISOS
            {
                MessageBox.Show($"EL ROL {comboBox1.Text} TIENE PERMISOS SOBRE EL MODULO {comboBox2.Text}");

                chkConsultar.Checked = permiso.consultar;
                chkCrear.Checked = permiso.crear;
                chkEditar.Checked = permiso.editar;
                chkEliminar.Checked = permiso.eliminar;
            }
            else // SI NO EXISTE INDICAR Y MOSTRAR QUE NO TIENE PERMISOS SOBRE EL MODULO{
            {
                MessageBox.Show($"EL ROL {comboBox1.Text} NO TIENE PERMISOS SOBRE EL MODULO {comboBox2.Text} SELECIONADO");

                chkConsultar.Checked = false;
                chkCrear.Checked = false;
                chkEditar.Checked = false;
                chkEliminar.Checked = false;
            }
        }

        public void dobleClickEliminarEditar(object sender, MouseEventArgs e)///NO TOMA LO NUEVO
        {
            try
            {   //validar si hay un elemento seleccionado
                if (listView1.SelectedItems.Count > 0)
                {
                    // Recupero el id que está en Tag
                    int id = (int)listView1.SelectedItems[0].Tag;

                    // Consulto en el servicio
                    var rool = _Service.consultarID(id);

                    if (rool != null)
                    {
                        frmEliminarEditar frm = new frmEliminarEditar();//SE INSTACIA UN FRM
                        frm.rolSelected = rool;//SE LE MANDA EL ROOL
                        frm.formPadre = this; //SE LE MANDA UNA REFERENCIA DEL FRM PADRE
                        frm.ShowDialog();//SE MUESTRA L FRM
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el producto de la lista");
            }
        }
    }
}

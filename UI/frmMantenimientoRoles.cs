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
//EDITAR ROLES 
//MOSTRAR MODULOS EXISTENTES
//MOSTRAR LOS PERMISOS AQUE TIENE CADA ROL

namespace UI
{
    public partial class frmMantenimientoRoles : Form
    {
        private readonly SeguridadService _Service;//ACCESO A SERVICE
        List<clsRol> lista;
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
            this.lista = _Service.consultarRoles(); ;
            cargarListaRoles(lista);
        }

        public void cargarRolesBox()//FUNCIONA
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

        private void cargarModulosBox()//FUNCIONA
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

        private void cargarListaRoles(List<clsRol> lista)
        {
            listView1.Items.Clear();

            foreach (clsRol roles in lista)
            {
                ListViewItem item = new ListViewItem(roles.nombreRol);
                item.SubItems.Add(roles.descripcionRol);
                listView1.Items.Add(item);

                item.Tag = roles.idRol;
                listView1.Refresh();
            }
            this.Refresh();
            listView1.Refresh();
        }

        private void buttonCrearRol_Click(object sender, EventArgs e)
        {
            try
            {//FALTA EXEPCION DE NULL
                clsRol roool = new clsRol();

                roool.nombreRol = textBoxNombreRol.Text;
                roool.descripcionRol = richTextBoxDescripcionRol.Text;

                //llamo a mi capa de servicios para crear y guardar el nuevo rol
                _Service.crearRol(roool);
                MessageBox.Show("ROL CREADO CORRECTAMENTE");

                //LIMPIAR CAMPOS
                textBoxNombreRol.Clear();
                richTextBoxDescripcionRol.Clear();

                cargarListaRoles(lista);//ACTUALIZAR LISTA DE ROLES
            }
            catch (NullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EntityExistDBException ex)//EXEPCION DE ID REPETIDO 
            {
                MessageBox.Show(ex.Message);
            }
            catch (NameProductExistDBException ex)//EXEPCION DE NOMBRE REPETIDO
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)//EXEPCION DESCONOCIDA
            {
                MessageBox.Show("Error desconocido. Contante con el administrador.");
            }
        }

        private void buttonCrearPermiso_Click(object sender, EventArgs e)//FUNCIONA
        {
            try
            {//CONSULTAR SI EXISTE EN PERMISOS
                int idRol = Convert.ToInt32(comboBox1.SelectedValue);
                int idModulo = Convert.ToInt32(comboBox2.SelectedValue);
                string nombreRol = comboBox1.DisplayMember;
                string nombreModulo = comboBox2.DisplayMember;

                var permiso = _Service.consultarPermi(idRol, idModulo);

                if (permiso != null)//SI EXISTE
                {
                    DialogResult result = MessageBox.Show("SEGURO DE QUE QUIERE GUARDAR CAMBIOS?", "CAMBIO REALIZADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!chkConsultar.Checked && !chkEditar.Checked && !chkEliminar.Checked && !chkCrear.Checked)
                        {
                            //SI EXISTE Y SE GUARDA VACIO SE ELIMINA DEL DB
                            MessageBox.Show($"PERMISO MODIFICADO, EL ROL {comboBox1.Text} YA NO TIENE PERMISO SOBRE EL MODULO {comboBox2.Text}");
                            _Service.eliminarPermiso(permiso);
                        }
                        else
                        {
                            //SI EXISTE SE MODIFICA  
                            permiso.consultar = chkConsultar.Checked;
                            permiso.crear = chkCrear.Checked;
                            permiso.editar = chkEditar.Checked;
                            permiso.eliminar = chkEliminar.Checked;
                            _Service.modificarPermiso(permiso);
                            MessageBox.Show("PERMISO MODIFICADO");
                        }
                    }
                }
                else//SI NO EXISTE SE CREA
                {
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
                        MessageBox.Show($" PERMISO DEL ROL {comboBox1.Text} SOBRE EL MODULO {comboBox2.Text} CREADO CORRECTAMENTAMENTE");
                    }
                }
            }
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NameProductExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buscarPermiso_Click(object sender, EventArgs e)
        {
            // 1 VERIFICAR QUE EXISTE ID EN DB
            int idRol = Convert.ToInt32(comboBox1.SelectedValue);
            int idModulo = Convert.ToInt32(comboBox2.SelectedValue);

            // Llamar al DAO
            var permiso = _Service.consultarPermi(idRol, idModulo);

            if (permiso != null)// 2 SII EXISTE MOSTRAR PERMISOS
            {
                MessageBox.Show($"EL ROL {comboBox1.Text} TIENE PERMISOS SOBRE EL MODULO {comboBox2.Text}");

                chkConsultar.Checked = permiso.consultar;
                chkCrear.Checked = permiso.crear;
                chkEditar.Checked = permiso.editar;
                chkEliminar.Checked = permiso.eliminar;
            }
            else // SI NO EXISTE INDICAR QUE NO TIENE PERMISOS SOBRE EL MODULO{
            {
                MessageBox.Show($"EL ROL {comboBox1.Text} NO TIENE PERMISOS SOBRE EL MODULO {comboBox2.Text} SELECIONADO");

                chkConsultar.Checked = false;
                chkCrear.Checked = false;
                chkEditar.Checked = false;
                chkEliminar.Checked = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void checkCrear(object sender, EventArgs e)
        {

        }

        private void checkConsultar(object sender, EventArgs e)
        {

        }

        private void checkModificar(object sender, EventArgs e)
        {

        }

        private void checkEliminar(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dobleClickEliminarEditar(object sender, MouseEventArgs e)
        {
            try
            {
                //validar si hay un elemento seleccionado
                if (listView1.SelectedItems.Count > 0)
                {
                    // Recupero el id que está en Tag
                    int id = (int)listView1.SelectedItems[0].Tag;

                    // Consulto en el servicio
                    var rool = _Service.consultarID(id);

                    if (rool != null)
                    {
                        //creo una instancia del formulario de producto
                        frmEliminarEditar frm = new frmEliminarEditar();
                        //le asigno a la propiedad el producto seleccionado
                        frm.rolSelected = rool;

                        frm.FormClosed += (s, args) =>
                        {
                            this.Show(); // Vuelvo a mostrar el padre siempre que se cierre el hijo
                        };

                        this.Hide();

                        frm.ShowDialog();
                    }
                }   
            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar el producto de la lista");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

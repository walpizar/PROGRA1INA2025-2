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
    public partial class frmEliminarEditar : Form
    {

        private readonly SeguridadService _Service;//ACCESO A SERVICE
        public clsRol rolSelected { get; set; }//REFERENCIA DE ROL DESDE EL FRM PADRE

        public frmMantenimientoRoles formPadre { get; set; }//REFERNCIA DEL FRM PADRE

        public frmEliminarEditar()
        {
            InitializeComponent();
            _Service = new SeguridadService();//INICIALIZO EL ACCESO
        }

        private void frmEliminarEditar_Load(object sender, EventArgs e)
        {
            cargarSelecionado();
        }

        public void cargarSelecionado()//MUESTRO
        {
            var existente = _Service.consultarID(rolSelected.idRol);

            if (existente != null)//SI EXISTE EL EPRMISO SELECIONADO TRAIGO SU NOMBRE Y DESCRIPCION DESDE LA DB 
            {
                textBox1.Text = existente.nombreRol;
                richTextBox1.Text = existente.descripcionRol;
            }
        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {
            _Service.eliminando(rolSelected.idRol);

            MessageBox.Show("ROL ELIMINANDO CORRECTAMENTE");

            formPadre.cargarListaRoles(_Service.consultarRoles());
            formPadre.cargarListaPermisos(_Service.consultarPermisos());

            this.Close();//CIERRO FRM
        }

        private void button2_Click(object sender, EventArgs e)//ACTUALIZAR//EDITAR
        {
            var existente = _Service.consultarID(rolSelected.idRol);

            if (existente != null)//SI EXISTE SE LE DA DATOS
            {
                existente.nombreRol = textBox1.Text;
                existente.descripcionRol = richTextBox1.Text;
                _Service.editarRol(existente);//EDITAR
            }
            MessageBox.Show("ROL ACTUALIZADO CORRECTAMENTE");

            formPadre.cargarListaRoles(_Service.consultarRoles()); //REGARGO METODO DEL FRM PADRE DESDE EL FRM HIJO

            this.Close();
        }

        private void frmEliminarEditar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPadre.cargarListaRoles(_Service.consultarRoles());  //REGARGO METODO DEL FRM PADRE DESDE EL FRM HIJO
            this.Close();
        }
    }
}

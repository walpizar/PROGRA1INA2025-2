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

        private readonly SeguridadService _Service;
        public clsRol rolSelected { get; set; }

        public frmMantenimientoRoles formPadre { get; set; }

        public frmEliminarEditar()
        {
            InitializeComponent();
            _Service = new SeguridadService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmEliminarEditar_Load(object sender, EventArgs e)
        {
            cargarSelecionado();
        }

        public void cargarSelecionado()
        {
            var existente = _Service.consultarID(rolSelected.idRol);

            if (existente != null)
            {
                // Asigno los valores actuales a los controles
                textBox1.Text = existente.nombreRol;
                richTextBox1.Text = existente.descripcionRol;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {

            int idRol = rolSelected.idRol;
            _Service.eliminando(idRol);

            MessageBox.Show("ROL ELIMINANDO CORRECTAMENTE");

            formPadre.cargarListaRoles(_Service.consultarRoles()); // recargo lista

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//ACTUALIZAR//EDITAR
        {

            var existente = _Service.consultarID(rolSelected.idRol);

            if (existente != null)
            {
                existente.nombreRol = textBox1.Text;
                existente.descripcionRol = richTextBox1.Text;
                // Si usas base de datos: _context.SaveChanges();
            }

            _Service.editarRol(existente);

            MessageBox.Show("ROL ACTUALIZADO CORRECTAMENTE");

            formPadre.cargarListaRoles(_Service.consultarRoles()); // recargo lista

            this.Close();
        }


        private void frmEliminarEditar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPadre.cargarListaRoles(_Service.consultarRoles()); // recargo lista
            this.Close();
        }


    }
}

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

        public frmMantenimientoRoles Padre { get; set; }

        List<clsRol> lista;


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

        public void cargarSelecionado()
        {
            if (rolSelected != null)
            {
                // Asigno los valores actuales a los controles
                textBox1.Text = rolSelected.nombreRol;
                richTextBox1.Text = rolSelected.descripcionRol;
            }
            else
            {
                // Si no hay rol seleccionado, limpio los campos
                textBox1.Clear();
                richTextBox1.Clear();
            }
        }

        private void frmEliminarEditar_Load(object sender, EventArgs e)
        {
            this.lista = _Service.consultarRoles(); // traigo los roles actualizados
            cargarSelecionado();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {

             int idRol = rolSelected.idRol;
            _Service.eliminando(idRol);

            MessageBox.Show("ROL ELIMINANDO CORRECTAMENTE");

            Padre?.cargarListaRoles(_Service.consultarRoles()); // recargo lista

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

            Padre?.cargarListaRoles(_Service.consultarRoles()); // recargo lista

            this.Close();
        }


        private void frmEliminarEditar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Padre?.cargarListaRoles(_Service.consultarRoles()); // recargo lista
            this.Close();
        }
    }
}

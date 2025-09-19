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
                textBox1.Text = rolSelected.nombreRol;
                richTextBox1.Text = rolSelected.descripcionRol;
            }
        }

        private void frmEliminarEditar_Load(object sender, EventArgs e)
        {
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

            this.Close();

            frmMantenimientoRoles frmMant = new frmMantenimientoRoles();
            frmMant.Show();
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

            frmMantenimientoRoles frmMant = new frmMantenimientoRoles();

            this.Hide(); // o this.Close() si de verdad quieres cerrarlo
            frmMant.ShowDialog();
            this.Show();

            this.Close();
        }
    }
}

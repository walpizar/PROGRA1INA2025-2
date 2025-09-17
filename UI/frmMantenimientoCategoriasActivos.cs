using DAO;
using DAO.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMantenimientoCategoriasActivos : Form
    {
        private readonly CategoriaActivosService _service;

        public frmMantenimientoCategoriasActivos()
        {
            InitializeComponent();

            // 🔹 Crear contexto y DAO
            var context = new dbContextINA();
            var dao = new CategoriaActivosDAO(context);
            _service = new CategoriaActivosService(dao);

            // Configuración del ListView
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void frmMantenimientoCategoriasActivos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            listView1.Items.Clear();

            List<clsCategoriaActivos> categorias = _service.consultarTodos();

            foreach (var cat in categorias)
            {
                var item = new ListViewItem(cat.Id.ToString()); // Columna ID
                item.SubItems.Add(cat.nombre);                  // Columna Nombre
                item.SubItems.Add(cat.descripcion ?? "");       // Columna Descripción
                item.SubItems.Add(cat.estado ? "Activo" : "Inactivo"); // Columna Estado

                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaCategoria = new clsCategoriaActivos
                {
                    nombre = textBox1.Text.Trim(),
                    descripcion = richTextBox1.Text.Trim(),
                    estado = checkBox1.Checked
                };

                _service.crear(nuevaCategoria);

                MessageBox.Show("Categoría guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCategorias();

                // Limpiar controles
                textBox1.Clear();
                richTextBox1.Clear();
                checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

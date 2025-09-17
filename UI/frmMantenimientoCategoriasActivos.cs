using DAO;
using Entities;
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

            // 🔹 Configuración del ListView
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;

            // 🔹 Agregar columnas
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Descripción", 200);
            listView1.Columns.Add("Estado", 80);
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
                var item = new ListViewItem(cat.Id.ToString());              // Columna ID
                item.SubItems.Add(cat.nombre);                               // Columna Nombre
                item.SubItems.Add(cat.descripcion ?? "");                    // Columna Descripción
                item.SubItems.Add(cat.estado ? "Activo" : "Inactivo");       // Columna Estado

                listView1.Items.Add(item);
            }
        }

        // 🔹 CREAR
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
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 ELIMINAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            var item = listView1.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            if (MessageBox.Show("¿Está seguro de eliminar esta categoría?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.eliminar(id);
                MessageBox.Show("Categoría eliminada correctamente.");
                CargarCategorias();
            }
        }

        // 🔹 MODIFICAR (cargar datos en controles)
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
                return;
            }

            var item = listView1.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            var categoria = _service.consultarPorID(id); // 👈 corregido

            if (categoria != null)
            {
                label3.Text = categoria.Id.ToString();     // mostrar ID
                textBox1.Text = categoria.nombre;
                richTextBox1.Text = categoria.descripcion;
                checkBox1.Checked = categoria.estado;
            }
        }

        // 🔹 ACTUALIZAR
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label3.Text) || label3.Text == "0")
            {
                MessageBox.Show("Seleccione primero una categoría con 'Modificar'.");
                return;
            }

            int id = int.Parse(label3.Text);

            var categoria = new clsCategoriaActivos
            {
                Id = id,
                nombre = textBox1.Text.Trim(),
                descripcion = richTextBox1.Text.Trim(),
                estado = checkBox1.Checked
            };

            _service.modificar(categoria); // 👈 corregido (era actualizar)
            MessageBox.Show("Categoría actualizada correctamente.");
            CargarCategorias();

            LimpiarControles();
        }

        private void LimpiarControles()
        {
            label3.Text = "0";
            textBox1.Clear();
            richTextBox1.Clear();
            checkBox1.Checked = false;
        }
    }
}

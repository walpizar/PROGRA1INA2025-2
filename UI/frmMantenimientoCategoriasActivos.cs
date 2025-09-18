using Entities;
using DAO;
using DAO.Interfaces;
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

            var context = new dbContextINA();
            var dao = new CategoriaActivosDAO(context);
            _service = new CategoriaActivosService(dao);

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;

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
                var item = new ListViewItem(cat.Id.ToString());
                item.SubItems.Add(cat.nombre);
                item.SubItems.Add(cat.descripcion ?? "");
                item.SubItems.Add(cat.estado ? "Activo" : "Inactivo");
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Crear
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
                MessageBox.Show("Categoría guardada correctamente.");
                CargarCategorias();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Eliminar
        {
            if (listView1.SelectedItems.Count == 0) return;

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            if (MessageBox.Show("¿Eliminar categoría?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.eliminar(id);
                MessageBox.Show("Categoría eliminada.");
                CargarCategorias();
            }
        }

        private void button3_Click(object sender, EventArgs e) // Modificar (cargar)
        {
            if (listView1.SelectedItems.Count == 0) return;

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            var cat = _service.consultarPorID(id);
            if (cat != null)
            {
                label3.Text = cat.Id.ToString();
                textBox1.Text = cat.nombre;
                richTextBox1.Text = cat.descripcion;
                checkBox1.Checked = cat.estado;
            }
        }

        private void button4_Click(object sender, EventArgs e) // Actualizar
        {
            if (string.IsNullOrEmpty(label3.Text) || label3.Text == "0") return;

            int id = int.Parse(label3.Text);
            var categoria = _service.consultarPorID(id);
            if (categoria != null)
            {
                categoria.nombre = textBox1.Text.Trim();
                categoria.descripcion = richTextBox1.Text.Trim();
                categoria.estado = checkBox1.Checked;

                _service.modificar(categoria);
                MessageBox.Show("Categoría actualizada.");
                CargarCategorias();
                LimpiarControles();
            }
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

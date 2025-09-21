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
                // Llenar los controles de la pestaña Modificar (tabPage3)
                label10.Text = cat.Id.ToString();   // ID
                textBox2.Text = cat.nombre;         // Nombre
                richTextBox2.Text = cat.descripcion; // Descripción

                // Cambiar de pestaña
                tabControl1.SelectedTab = tabPage3;
            }
        }


        private void button4_Click(object sender, EventArgs e) // Actualizar
        {
            if (string.IsNullOrEmpty(label10.Text)) return;

            int id = int.Parse(label10.Text);
            var categoria = _service.consultarPorID(id);
            if (categoria != null)
            {
                categoria.nombre = textBox2.Text.Trim();
                categoria.descripcion = richTextBox2.Text.Trim();

                _service.modificar(categoria);
                MessageBox.Show("Categoría actualizada.");

                CargarCategorias();

                // Regresar a la pestaña de lista
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void LimpiarControles()
        {
            label3.Text = "";
            textBox1.Clear();
            richTextBox1.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

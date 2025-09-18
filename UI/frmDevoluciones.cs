using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public class frmDevoluciones : Form
    {
        private readonly DevolucionService _devolucionService;
        private readonly ActivosServices _activosService;

        private Label lblTitulo;
        private DataGridView dgvDevoluciones;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCerrar;

        public frmDevoluciones()
        {
            _devolucionService = new DevolucionService();
            _activosService = new ActivosServices();

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvDevoluciones = new DataGridView();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();

            SuspendLayout();
            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 21);
            lblTitulo.Text = "Listado de Devoluciones";

            // dgvDevoluciones
            dgvDevoluciones.Location = new Point(15, 50);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.Size = new Size(740, 330);
            dgvDevoluciones.ReadOnly = true;
            dgvDevoluciones.AllowUserToAddRows = false;
            dgvDevoluciones.AllowUserToDeleteRows = false;
            dgvDevoluciones.MultiSelect = false;
            dgvDevoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevoluciones.AutoGenerateColumns = false;
            dgvDevoluciones.CellDoubleClick += dgvDevoluciones_CellDoubleClick;

            // Columnas
            dgvDevoluciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60
            });
            dgvDevoluciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha devolución",
                Width = 140
            });
            dgvDevoluciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Activo",
                HeaderText = "Activo",
                Width = 240
            });
            dgvDevoluciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observaciones",
                HeaderText = "Observaciones",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // btnCrear
            btnCrear.Location = new Point(280, 395);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(90, 25);
            btnCrear.Text = "Crear";
            btnCrear.Click += btnCrear_Click;

            // btnEditar
            btnEditar.Location = new Point(375, 395);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 25);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;

            // btnEliminar
            btnEliminar.Location = new Point(470, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 25);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;

            // btnActualizar
            btnActualizar.Location = new Point(565, 395);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 25);
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;

            // btnCerrar
            btnCerrar.Location = new Point(660, 395);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 25);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;

            // frmDevoluciones
            ClientSize = new Size(774, 441);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDevoluciones);
            Controls.Add(btnCrear);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Name = "frmDevoluciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devoluciones";
            Load += frmDevoluciones_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            CargarDevoluciones();
        }

        private void CargarDevoluciones()
        {
            try
            {
                var lista = _devolucionService.consultarTodos() ?? new List<clsDevolucion>();

                // Proyección para el grid, resolviendo nombre de activo si es necesario
                var data = lista.Select(d =>
                {
                    string nombreActivo = d.activo?.nombreActivo;
                    if (string.IsNullOrWhiteSpace(nombreActivo))
                    {
                        var act = _activosService.consultarPorID(d.idActivoFK);
                        nombreActivo = act?.nombreActivo ?? $"ID {d.idActivoFK}";
                    }

                    return new
                    {
                        Id = d.idDevolucion,
                        Fecha = d.fechaDevolucion.ToString("yyyy-MM-dd"),
                        Activo = nombreActivo,
                        Observaciones = d.observaciones ?? string.Empty
                    };
                })
                .OrderByDescending(x => x.Fecha)
                .ThenByDescending(x => x.Id)
                .ToList();

                dgvDevoluciones.DataSource = null;
                dgvDevoluciones.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Error al cargar las devoluciones.");
                dgvDevoluciones.DataSource = null;
            }
        }

        private int? GetIdSeleccionado()
        {
            if (dgvDevoluciones.CurrentRow == null) return null;
            if (dgvDevoluciones.CurrentRow.DataBoundItem == null) return null;

            var idProp = dgvDevoluciones.CurrentRow.Cells["Id"]?.Value;
            if (idProp == null) return null;

            return int.TryParse(idProp.ToString(), out var id) ? id : null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de crear/modificar
            using var frm = new frmDevolucion
            {
                devolucionSelected = null
            };
            frm.ShowDialog(this);
            // Al cerrar, refrescar el listado
            CargarDevoluciones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Seleccione una devolución para editar.");
                return;
            }

            var selected = _devolucionService.consultarPorID(id.Value);
            if (selected == null)
            {
                MessageBox.Show("No se encontró la devolución seleccionada.");
                return;
            }

            using var frm = new frmDevolucion
            {
                devolucionSelected = selected
            };
            frm.ShowDialog(this);
            CargarDevoluciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (id == null)
            {
                MessageBox.Show("Seleccione una devolución para eliminar.");
                return;
            }

            var resp = MessageBox.Show("¿Está seguro que desea eliminar la devolución?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp != DialogResult.Yes) return;

            try
            {
                _devolucionService.eliminar(id.Value);
                CargarDevoluciones();
                MessageBox.Show("Devolución eliminada correctamente.");
            }
            catch
            {
                MessageBox.Show("Error al eliminar la devolución.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDevoluciones();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDevoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnEditar_Click(sender, e);
        }
    }
}
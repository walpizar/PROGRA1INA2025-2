using Common.Exceptions;
using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using static Common.Enums.Enums;

namespace UI
{
    public class frmDevolucion : Form
    {
        public clsDevolucion devolucionSelected { get; set; }

        private readonly DevolucionService _devolucionService;
        private readonly ActivosServices _activosService;

        private Label lblTitulo;
        private Label lblActivo;
        private ComboBox cboActivo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblObs;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEliminar;

        public frmDevolucion()
        {
            _devolucionService = new DevolucionService();
            _activosService = new ActivosServices();

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblActivo = new Label();
            cboActivo = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblObs = new Label();
            txtObservaciones = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Devolución";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(15, 60);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(44, 15);
            lblActivo.TabIndex = 1;
            lblActivo.Text = "Activo:";
            // 
            // cboActivo
            // 
            cboActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivo.Location = new Point(120, 55);
            cboActivo.Name = "cboActivo";
            cboActivo.Size = new Size(380, 23);
            cboActivo.TabIndex = 2;
            cboActivo.SelectedIndexChanged += cboActivo_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 100);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(103, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha devolución:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(120, 95);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 4;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(15, 140);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(87, 15);
            lblObs.TabIndex = 5;
            lblObs.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(15, 165);
            txtObservaciones.MaxLength = 200;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(485, 90);
            txtObservaciones.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(315, 270);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 270);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmDevolucion
            // 
            ClientSize = new Size(544, 321);
            Controls.Add(lblTitulo);
            Controls.Add(lblActivo);
            Controls.Add(cboActivo);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblObs);
            Controls.Add(txtObservaciones);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Name = "frmDevolucion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Devolución de Activo";
            Load += frmDevolucion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            cargarActivos();

            if (devolucionSelected != null)
            {
                lblTitulo.Text = "Modificar Devolución";
                Text = "Modificar Devolución";
                btnEliminar.Visible = true;

                dtpFecha.Value = devolucionSelected.fechaDevolucion == default
                    ? DateTime.Today
                    : devolucionSelected.fechaDevolucion;

                txtObservaciones.Text = devolucionSelected.observaciones ?? string.Empty;
                cboActivo.SelectedValue = devolucionSelected.idActivoFK;
            }
            else
            {
                lblTitulo.Text = "Registrar Devolución";
                Text = "Registrar Devolución";
                btnEliminar.Visible = false;
                dtpFecha.Value = DateTime.Today;
            }
        }

        private void cargarActivos()
        {
            try
            {
                var activos = _activosService.consultarTodos() ?? new List<clsActivos>();

                var filtrados = activos
                    .Where(a => a != null && a.estado) // Activo lógico
                    .Where(a => ((EstadoUsoActivo)a.estadoUso) is EstadoUsoActivo.Prestado or EstadoUsoActivo.EnUso)
                    .OrderBy(a => a.nombreActivo)
                    .ToList();

                // Permite ver el activo original al editar aunque ya no cumpla el filtro.
                if (devolucionSelected != null &&
                    filtrados.All(a => a.idActivo != devolucionSelected.idActivoFK))
                {
                    var seleccionado = _activosService.consultarPorID(devolucionSelected.idActivoFK);
                    if (seleccionado != null)
                        filtrados.Insert(0, seleccionado);
                }

                cboActivo.DataSource = null;
                cboActivo.DisplayMember = nameof(clsActivos.nombreActivo);
                cboActivo.ValueMember = nameof(clsActivos.idActivo);
                cboActivo.DataSource = filtrados;

                if (filtrados.Count == 0)
                {
                    cboActivo.SelectedIndex = -1;
                    MessageBox.Show("No hay activos prestados o en uso disponibles para devolución.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los activos desde la base de datos.");
                cboActivo.DataSource = null;
                cboActivo.Items.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarDatos()) return;

                var devolucion = devolucionSelected ?? new clsDevolucion
                {
                    fechaDevolucion = dtpFecha.Value.Date
                };

                devolucion.idActivoFK = (int)cboActivo.SelectedValue;
                devolucion.fechaDevolucion = dtpFecha.Value.Date;
                devolucion.observaciones = txtObservaciones.Text?.Trim() ?? string.Empty;

                if (devolucionSelected == null)
                {
                    _devolucionService.crear(devolucion);
                    MessageBox.Show("Devolución registrada correctamente.");
                }
                else
                {
                    _devolucionService.modificar(devolucion);
                    MessageBox.Show("Devolución modificada correctamente.");
                }

                // Estándar: cerrar tras guardar y que la lista refresque
                Close();
            }
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar la devolución. Contacte al administrador.");
            }
        }

        private bool validarDatos()
        {
            if (cboActivo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un activo.");
                cboActivo.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtObservaciones.Text) && txtObservaciones.Text.Length > 200)
            {
                MessageBox.Show("Las observaciones no pueden exceder 200 caracteres.");
                txtObservaciones.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (devolucionSelected == null)
                {
                    MessageBox.Show("No hay una devolución seleccionada.");
                    return;
                }

                var resp = MessageBox.Show("¿Está seguro que desea eliminar la devolución?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    _devolucionService.eliminar(devolucionSelected.idDevolucion);
                    MessageBox.Show("Devolución eliminada correctamente.");
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar la devolución.");
            }
        }

        private void cboActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
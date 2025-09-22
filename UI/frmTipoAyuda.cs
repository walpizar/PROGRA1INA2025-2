using Common.Enums;
using Entities;
using Services;
using System;
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
    public partial class frmTipoAyuda : Form
    {

        public clsTiposAyudas selectTiposAyudas { get; set; }

        private readonly TipoAyudasService _tipoAyudasService;
        private readonly UsuarioService _usuarioService;
        public frmTipoAyuda()
        {
            InitializeComponent();
            _tipoAyudasService = new TipoAyudasService();
            _usuarioService = new UsuarioService();
        }


        private void limpiarForm()
        {
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            cboResponsable.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            lblTiposAyudas = new Label();
            grbTiposAyudas = new GroupBox();
            cboResponsable = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            lblResponsable = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            grbTiposAyudas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTiposAyudas
            // 
            lblTiposAyudas.AutoSize = true;
            lblTiposAyudas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposAyudas.Location = new Point(125, 19);
            lblTiposAyudas.Name = "lblTiposAyudas";
            lblTiposAyudas.Size = new Size(213, 30);
            lblTiposAyudas.TabIndex = 0;
            lblTiposAyudas.Text = "Crear Tipo de Ayuda";
            lblTiposAyudas.Click += lblTiposAyudas_Click;
            // 
            // grbTiposAyudas
            // 
            grbTiposAyudas.Controls.Add(cboResponsable);
            grbTiposAyudas.Controls.Add(txtDescripcion);
            grbTiposAyudas.Controls.Add(txtNombre);
            grbTiposAyudas.Controls.Add(lblResponsable);
            grbTiposAyudas.Controls.Add(lblDescripcion);
            grbTiposAyudas.Controls.Add(lblNombre);
            grbTiposAyudas.Location = new Point(30, 52);
            grbTiposAyudas.Name = "grbTiposAyudas";
            grbTiposAyudas.Size = new Size(395, 191);
            grbTiposAyudas.TabIndex = 1;
            grbTiposAyudas.TabStop = false;
            grbTiposAyudas.Text = "Datos tipos de ayudas";
            grbTiposAyudas.Enter += grbTiposAyudas_Enter;
            // 
            // cboResponsable
            // 
            cboResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResponsable.FormattingEnabled = true;
            cboResponsable.Location = new Point(114, 139);
            cboResponsable.Name = "cboResponsable";
            cboResponsable.Size = new Size(212, 23);
            cboResponsable.TabIndex = 5;
            cboResponsable.SelectedIndexChanged += cboResponsable_SelectedIndexChanged_1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(114, 78);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 49);
            txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(36, 139);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(76, 15);
            lblResponsable.TabIndex = 2;
            lblResponsable.Text = "Responsable:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(36, 91);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(54, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.DarkGreen;
            btnGuardar.Location = new Point(339, 259);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.DimGray;
            btnCancelar.Location = new Point(237, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Location = new Point(134, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 36);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.FromArgb(255, 128, 0);
            btnModificar.Location = new Point(30, 259);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 36);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // frmTipoAyuda
            // 
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(451, 307);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grbTiposAyudas);
            Controls.Add(lblTiposAyudas);
            Name = "frmTipoAyuda";
            Text = "Agregar Tipo de ayuda";
            Load += frmTipoAyuda_Load;
            grbTiposAyudas.ResumeLayout(false);
            grbTiposAyudas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label lblTiposAyudas;
        private GroupBox grbTiposAyudas;

        private void lblTiposAyudas_Click(object sender, EventArgs e)
        {

        }
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblResponsable;


        private ComboBox cboResponsable;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;

        private void frmTipoAyuda_Load(object sender, EventArgs e)
        {
            cargarCombos();

            if (selectTiposAyudas == null)
            {
                // Caso: nuevo registro
                btnGuardar.Visible = true;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                this.Text = "Nuevo Tipo de Ayuda";
            }
            else
            {
                // Caso: edición
                btnEliminar.Visible = true;
                btnCancelar.Visible = true;
                btnModificar.Visible = true;
                btnGuardar.Visible = false;
                txtNombre.Text = selectTiposAyudas.nombre;
                txtDescripcion.Text = selectTiposAyudas.descripcion;

                // Buscar y seleccionar responsable en el combo
                foreach (clsUsuario u in cboResponsable.Items)
                {
                    if (u.id == selectTiposAyudas.id_responsable &&
                        u.personaTipoId == selectTiposAyudas.personaTipoId_responsable)
                    {
                        cboResponsable.SelectedItem = u;
                        break;
                    }
                }


                this.Text = "Editar Tipo de Ayuda";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar datos de entrada
                if (true)
                {
                    // Creo la instancia de tipo de ayuda nuevo
                    clsTiposAyudas tiposAyudas = selectTiposAyudas ?? new clsTiposAyudas();

                    tiposAyudas.nombre = txtNombre.Text;
                    tiposAyudas.descripcion = txtDescripcion.Text;

                    // 👇 Corregido: tomar el usuario seleccionado
                    var usuarioSeleccionado = (clsUsuario)cboResponsable.SelectedItem;

                    tiposAyudas.id_responsable = usuarioSeleccionado.id;
                    tiposAyudas.personaTipoId_responsable = usuarioSeleccionado.personaTipoId;

                    // Auditoría (asumimos que el usuario logueado es el que crea)
                    tiposAyudas.id_usuarioCrea = usuarioSeleccionado.id;
                    tiposAyudas.personaTipoId_usuarioCrea = usuarioSeleccionado.personaTipoId;
                    tiposAyudas.id_usuarioUltimaModificacion = usuarioSeleccionado.id;
                    tiposAyudas.personaTipoId_usuarioUltimaModificacion = usuarioSeleccionado.personaTipoId;

                    if (selectTiposAyudas == null)
                        _tipoAyudasService.Crear(tiposAyudas);
                    else
                        _tipoAyudasService.modificar(tiposAyudas);

                    // Limpiar y cerrar
                    limpiarForm();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el tipo de ayuda");
                throw;
            }

        }
        private void cargarCombos()
        {
            List<clsUsuario> listaCat = _usuarioService.consultarTodos();
            cboResponsable.DataSource = listaCat;
            cboResponsable.DisplayMember = "id";
            cboResponsable.ValueMember = "id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cboResponsable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboResponsable.SelectedItem != null)
            {
                clsUsuario usuarioSeleccionado = (clsUsuario)cboResponsable.SelectedItem;


            }

        }

        private void grbTiposAyudas_Enter(object sender, EventArgs e)
        {

        }
        private Button btnEliminar;

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectTiposAyudas != null)
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar este tipo de ayuda?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    _tipoAyudasService.Eliminar(selectTiposAyudas.id_tipoAyuda);
                    MessageBox.Show("Tipo de ayuda eliminado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El tipo de ayuda " + selectTiposAyudas.nombre + " no se elimino");
                }
            }
                

        }
        private Button btnModificar;


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectTiposAyudas != null)
                {
                    var usuarioSeleccionado = (clsUsuario)cboResponsable.SelectedItem;

                    selectTiposAyudas.nombre = txtNombre.Text;
                    selectTiposAyudas.descripcion = txtDescripcion.Text;
                    selectTiposAyudas.id_responsable = usuarioSeleccionado.id;
                    selectTiposAyudas.personaTipoId_responsable = usuarioSeleccionado.personaTipoId;

                    selectTiposAyudas.id_usuarioUltimaModificacion = usuarioSeleccionado.id;
                    selectTiposAyudas.personaTipoId_usuarioUltimaModificacion = usuarioSeleccionado.personaTipoId;
                    selectTiposAyudas.fecha_ultimaModificacion = DateTime.Now;

                    _tipoAyudasService.modificar(selectTiposAyudas);

                    MessageBox.Show("Tipo de ayuda actualizado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }
    }
}

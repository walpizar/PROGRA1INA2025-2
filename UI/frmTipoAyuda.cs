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
        public frmTipoAyuda()
        {
            InitializeComponent();
            _tipoAyudasService = new TipoAyudasService();
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
            btnEliminar = new Button();
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
            // 
            // cboResponsable
            // 
            cboResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResponsable.FormattingEnabled = true;
            cboResponsable.Location = new Point(114, 139);
            cboResponsable.Name = "cboResponsable";
            cboResponsable.Size = new Size(212, 23);
            cboResponsable.TabIndex = 5;
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
            lblResponsable.Click += label1_Click;
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
            btnGuardar.Location = new Point(309, 259);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(192, 0, 0);
            btnEliminar.Location = new Point(177, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 36);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Cancelar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmTipoAyuda
            // 
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(451, 307);
            Controls.Add(btnEliminar);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private ComboBox cboResponsable;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnEliminar;

        private void frmTipoAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    clsTiposAyudas tiposAyudas = selectTiposAyudas == null ? new clsTiposAyudas() : selectTiposAyudas;

                    tiposAyudas.nombre = txtNombre.Text;
                    tiposAyudas.descripcion = txtDescripcion.Text;
                    tiposAyudas.responsable = (clsUsuario)cboResponsable.SelectedItem;

                    if (selectTiposAyudas == null)
                    {

                        _tipoAyudasService.crear(tiposAyudas);
                        MessageBox.Show("Tipo de ayuda creado correctamente");


                    }
                    //else
                    //{
                    //es una modificacion
                    //_tipoAyudasService.(tiposAyudas);
                    //MessageBox.Show("Tipo de ayuda modificado correctamente");
                    //this.Close();
                    //}

                    limpiarForm();
                    this.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

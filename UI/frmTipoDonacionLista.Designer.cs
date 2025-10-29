namespace UI
{
    partial class frmTipoDonacionLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevotipoDonacion = new Button();
            gbxTipoDonacionLista = new GroupBox();
            chkbxTipoDonacAct = new CheckBox();
            dgrdvwDonacionReq = new DataGridView();
            tipoDonacionReqMonto = new DataGridViewCheckBoxColumn();
            tipoDonacionReqTipoTransac = new DataGridViewCheckBoxColumn();
            tipoDonacionReqFrec = new DataGridViewCheckBoxColumn();
            tipoDonacionReqTipoMoneda = new DataGridViewCheckBoxColumn();
            txtbxBuscarTipoDonacion = new TextBox();
            lstvwTipoDonacionLista = new ListView();
            tipoDonacionID = new ColumnHeader();
            tipoDonacionNombre = new ColumnHeader();
            tipoDonacionDesc = new ColumnHeader();
            lblBuscarTipoDonacion = new Label();
            lblManttipoDonacion = new Label();
            btnSelecTipoDonacion = new Button();
            gbxTipoDonacionLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrdvwDonacionReq).BeginInit();
            SuspendLayout();
            // 
            // btnNuevotipoDonacion
            // 
            btnNuevotipoDonacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevotipoDonacion.Location = new Point(495, 46);
            btnNuevotipoDonacion.Name = "btnNuevotipoDonacion";
            btnNuevotipoDonacion.Size = new Size(96, 29);
            btnNuevotipoDonacion.TabIndex = 10;
            btnNuevotipoDonacion.Text = "NUEVO";
            btnNuevotipoDonacion.UseVisualStyleBackColor = true;
            btnNuevotipoDonacion.Click += btnNuevotipoDonacion_Click;
            // 
            // gbxTipoDonacionLista
            // 
            gbxTipoDonacionLista.Controls.Add(chkbxTipoDonacAct);
            gbxTipoDonacionLista.Controls.Add(dgrdvwDonacionReq);
            gbxTipoDonacionLista.Controls.Add(txtbxBuscarTipoDonacion);
            gbxTipoDonacionLista.Controls.Add(lstvwTipoDonacionLista);
            gbxTipoDonacionLista.Controls.Add(lblBuscarTipoDonacion);
            gbxTipoDonacionLista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxTipoDonacionLista.Location = new Point(6, 78);
            gbxTipoDonacionLista.Name = "gbxTipoDonacionLista";
            gbxTipoDonacionLista.Size = new Size(594, 526);
            gbxTipoDonacionLista.TabIndex = 9;
            gbxTipoDonacionLista.TabStop = false;
            gbxTipoDonacionLista.Text = "LISTA TIPO DONACIONES";
            // 
            // chkbxTipoDonacAct
            // 
            chkbxTipoDonacAct.AutoSize = true;
            chkbxTipoDonacAct.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkbxTipoDonacAct.Location = new Point(457, 37);
            chkbxTipoDonacAct.Name = "chkbxTipoDonacAct";
            chkbxTipoDonacAct.Size = new Size(118, 21);
            chkbxTipoDonacAct.TabIndex = 4;
            chkbxTipoDonacAct.Text = "ACTIVAR TIPO";
            chkbxTipoDonacAct.UseVisualStyleBackColor = true;
            chkbxTipoDonacAct.CheckedChanged += chkbxTipoDonacAct_CheckedChanged;
            // 
            // dgrdvwDonacionReq
            // 
            dgrdvwDonacionReq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrdvwDonacionReq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdvwDonacionReq.Columns.AddRange(new DataGridViewColumn[] { tipoDonacionReqMonto, tipoDonacionReqTipoTransac, tipoDonacionReqFrec, tipoDonacionReqTipoMoneda });
            dgrdvwDonacionReq.Location = new Point(6, 435);
            dgrdvwDonacionReq.Name = "dgrdvwDonacionReq";
            dgrdvwDonacionReq.RowHeadersWidth = 51;
            dgrdvwDonacionReq.Size = new Size(579, 85);
            dgrdvwDonacionReq.TabIndex = 3;
            // 
            // tipoDonacionReqMonto
            // 
            tipoDonacionReqMonto.HeaderText = "Requiere Monto";
            tipoDonacionReqMonto.MinimumWidth = 6;
            tipoDonacionReqMonto.Name = "tipoDonacionReqMonto";
            tipoDonacionReqMonto.ReadOnly = true;
            // 
            // tipoDonacionReqTipoTransac
            // 
            tipoDonacionReqTipoTransac.HeaderText = "Requiere Tipo Transac";
            tipoDonacionReqTipoTransac.MinimumWidth = 6;
            tipoDonacionReqTipoTransac.Name = "tipoDonacionReqTipoTransac";
            tipoDonacionReqTipoTransac.ReadOnly = true;
            // 
            // tipoDonacionReqFrec
            // 
            tipoDonacionReqFrec.HeaderText = "Requiere Frecuencia";
            tipoDonacionReqFrec.MinimumWidth = 6;
            tipoDonacionReqFrec.Name = "tipoDonacionReqFrec";
            tipoDonacionReqFrec.ReadOnly = true;
            // 
            // tipoDonacionReqTipoMoneda
            // 
            tipoDonacionReqTipoMoneda.HeaderText = "Requiere Tipo Moneda";
            tipoDonacionReqTipoMoneda.MinimumWidth = 6;
            tipoDonacionReqTipoMoneda.Name = "tipoDonacionReqTipoMoneda";
            tipoDonacionReqTipoMoneda.ReadOnly = true;
            // 
            // txtbxBuscarTipoDonacion
            // 
            txtbxBuscarTipoDonacion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxBuscarTipoDonacion.Location = new Point(81, 32);
            txtbxBuscarTipoDonacion.Name = "txtbxBuscarTipoDonacion";
            txtbxBuscarTipoDonacion.Size = new Size(361, 30);
            txtbxBuscarTipoDonacion.TabIndex = 2;
            txtbxBuscarTipoDonacion.TextChanged += txtbxBuscarTipoDonacion_TextChanged;
            // 
            // lstvwTipoDonacionLista
            // 
            lstvwTipoDonacionLista.Columns.AddRange(new ColumnHeader[] { tipoDonacionID, tipoDonacionNombre, tipoDonacionDesc });
            lstvwTipoDonacionLista.FullRowSelect = true;
            lstvwTipoDonacionLista.GridLines = true;
            lstvwTipoDonacionLista.Location = new Point(6, 69);
            lstvwTipoDonacionLista.MultiSelect = false;
            lstvwTipoDonacionLista.Name = "lstvwTipoDonacionLista";
            lstvwTipoDonacionLista.Size = new Size(579, 360);
            lstvwTipoDonacionLista.TabIndex = 0;
            lstvwTipoDonacionLista.UseCompatibleStateImageBehavior = false;
            lstvwTipoDonacionLista.View = View.Details;
            lstvwTipoDonacionLista.MouseClick += lstvwTipoDonacionLista_MouseClick;
            lstvwTipoDonacionLista.MouseDoubleClick += lstvwTipoDonacionLista_MouseDoubleClick;
            // 
            // tipoDonacionID
            // 
            tipoDonacionID.Text = "ID";
            tipoDonacionID.Width = 100;
            // 
            // tipoDonacionNombre
            // 
            tipoDonacionNombre.Text = "NOMBRE";
            tipoDonacionNombre.Width = 175;
            // 
            // tipoDonacionDesc
            // 
            tipoDonacionDesc.Text = "DESCRIPCION";
            tipoDonacionDesc.Width = 300;
            // 
            // lblBuscarTipoDonacion
            // 
            lblBuscarTipoDonacion.AutoSize = true;
            lblBuscarTipoDonacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscarTipoDonacion.Location = new Point(6, 37);
            lblBuscarTipoDonacion.Name = "lblBuscarTipoDonacion";
            lblBuscarTipoDonacion.Size = new Size(69, 20);
            lblBuscarTipoDonacion.TabIndex = 0;
            lblBuscarTipoDonacion.Text = "BUSCAR";
            // 
            // lblManttipoDonacion
            // 
            lblManttipoDonacion.AutoSize = true;
            lblManttipoDonacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManttipoDonacion.Location = new Point(73, 18);
            lblManttipoDonacion.Name = "lblManttipoDonacion";
            lblManttipoDonacion.Size = new Size(339, 25);
            lblManttipoDonacion.TabIndex = 8;
            lblManttipoDonacion.Text = "MANTENIMIENTO TIPO DONACIONES";
            // 
            // btnSelecTipoDonacion
            // 
            btnSelecTipoDonacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecTipoDonacion.Location = new Point(393, 46);
            btnSelecTipoDonacion.Name = "btnSelecTipoDonacion";
            btnSelecTipoDonacion.Size = new Size(96, 29);
            btnSelecTipoDonacion.TabIndex = 11;
            btnSelecTipoDonacion.Text = "SELECT";
            btnSelecTipoDonacion.UseVisualStyleBackColor = true;
            btnSelecTipoDonacion.Click += btnSelecTipoDonacion_Click;
            // 
            // frmTipoDonacionLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 616);
            Controls.Add(btnSelecTipoDonacion);
            Controls.Add(btnNuevotipoDonacion);
            Controls.Add(gbxTipoDonacionLista);
            Controls.Add(lblManttipoDonacion);
            Name = "frmTipoDonacionLista";
            Text = "LISTA TIPO DONACION";
            Load += frmTipoDonacionLista_Load;
            gbxTipoDonacionLista.ResumeLayout(false);
            gbxTipoDonacionLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrdvwDonacionReq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevotipoDonacion;
        private GroupBox gbxTipoDonacionLista;
        private TextBox txtbxBuscarTipoDonacion;
        private ListView lstvwTipoDonacionLista;
        private ColumnHeader tipoDonacionID;
        private ColumnHeader tipoDonacionNombre;
        private ColumnHeader tipoDonacionDesc;
        private Label lblBuscarTipoDonacion;
        private Label lblManttipoDonacion;
        private DataGridView dgrdvwDonacionReq;
        private DataGridViewCheckBoxColumn tipoDonacionReqMonto;
        private DataGridViewCheckBoxColumn tipoDonacionReqTipoTransac;
        private DataGridViewCheckBoxColumn tipoDonacionReqFrec;
        private DataGridViewCheckBoxColumn tipoDonacionReqTipoMoneda;
        private CheckBox chkbxTipoDonacAct;
        private Button btnSelecTipoDonacion;
    }
}
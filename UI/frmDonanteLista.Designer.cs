namespace UI
{
    partial class frmDonanteLista
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
            lblMantDonante = new Label();
            gbxDonanteLista = new GroupBox();
            chkbxDonanteActivar = new CheckBox();
            txtbxBuscarDonante = new TextBox();
            lstvwDonanteLista = new ListView();
            donanteID = new ColumnHeader();
            donanteNombre = new ColumnHeader();
            donanteAp1 = new ColumnHeader();
            donanteAp2 = new ColumnHeader();
            donanteTipoDon = new ColumnHeader();
            donanteEmail = new ColumnHeader();
            donanteTelefono = new ColumnHeader();
            lblBuscarDonante = new Label();
            btnNuevoDonante = new Button();
            btnDonanteSelect = new Button();
            gbxDonanteLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblMantDonante
            // 
            lblMantDonante.AutoSize = true;
            lblMantDonante.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMantDonante.Location = new Point(433, 24);
            lblMantDonante.Name = "lblMantDonante";
            lblMantDonante.Size = new Size(262, 25);
            lblMantDonante.TabIndex = 1;
            lblMantDonante.Text = "MANTENIMIENTO DONANTE";
            // 
            // gbxDonanteLista
            // 
            gbxDonanteLista.Controls.Add(chkbxDonanteActivar);
            gbxDonanteLista.Controls.Add(txtbxBuscarDonante);
            gbxDonanteLista.Controls.Add(lstvwDonanteLista);
            gbxDonanteLista.Controls.Add(lblBuscarDonante);
            gbxDonanteLista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxDonanteLista.Location = new Point(12, 84);
            gbxDonanteLista.Name = "gbxDonanteLista";
            gbxDonanteLista.Size = new Size(1149, 449);
            gbxDonanteLista.TabIndex = 2;
            gbxDonanteLista.TabStop = false;
            gbxDonanteLista.Text = "LISTA DONANTES";
            // 
            // chkbxDonanteActivar
            // 
            chkbxDonanteActivar.AutoSize = true;
            chkbxDonanteActivar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkbxDonanteActivar.Location = new Point(929, 38);
            chkbxDonanteActivar.Name = "chkbxDonanteActivar";
            chkbxDonanteActivar.Size = new Size(152, 21);
            chkbxDonanteActivar.TabIndex = 3;
            chkbxDonanteActivar.Text = "ACTIVAR DONANTE";
            chkbxDonanteActivar.UseVisualStyleBackColor = true;
            chkbxDonanteActivar.CheckedChanged += chkbxDonanteActivar_CheckedChanged;
            // 
            // txtbxBuscarDonante
            // 
            txtbxBuscarDonante.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxBuscarDonante.Location = new Point(150, 29);
            txtbxBuscarDonante.Name = "txtbxBuscarDonante";
            txtbxBuscarDonante.Size = new Size(563, 30);
            txtbxBuscarDonante.TabIndex = 2;
            txtbxBuscarDonante.TextChanged += txtbxBuscarDonante_TextChanged;
            // 
            // lstvwDonanteLista
            // 
            lstvwDonanteLista.Columns.AddRange(new ColumnHeader[] { donanteID, donanteNombre, donanteAp1, donanteAp2, donanteTipoDon, donanteEmail, donanteTelefono });
            lstvwDonanteLista.FullRowSelect = true;
            lstvwDonanteLista.GridLines = true;
            lstvwDonanteLista.Location = new Point(6, 69);
            lstvwDonanteLista.MultiSelect = false;
            lstvwDonanteLista.Name = "lstvwDonanteLista";
            lstvwDonanteLista.Size = new Size(1137, 374);
            lstvwDonanteLista.TabIndex = 0;
            lstvwDonanteLista.UseCompatibleStateImageBehavior = false;
            lstvwDonanteLista.View = View.Details;
            lstvwDonanteLista.MouseClick += lstvwDonanteLista_MouseClick;
            lstvwDonanteLista.MouseDoubleClick += lstvwDonanteLista_MouseDoubleClick_1;
            // 
            // donanteID
            // 
            donanteID.Text = "ID";
            donanteID.Width = 100;
            // 
            // donanteNombre
            // 
            donanteNombre.Text = "NOMBRE";
            donanteNombre.Width = 175;
            // 
            // donanteAp1
            // 
            donanteAp1.Text = "APELLIDO1";
            donanteAp1.Width = 175;
            // 
            // donanteAp2
            // 
            donanteAp2.Text = " APELLIDO2";
            donanteAp2.Width = 175;
            // 
            // donanteTipoDon
            // 
            donanteTipoDon.DisplayIndex = 6;
            donanteTipoDon.Text = "TIPO DONANTE";
            donanteTipoDon.Width = 157;
            // 
            // donanteEmail
            // 
            donanteEmail.DisplayIndex = 4;
            donanteEmail.Text = "EMAIL";
            donanteEmail.Width = 200;
            // 
            // donanteTelefono
            // 
            donanteTelefono.DisplayIndex = 5;
            donanteTelefono.Text = "TELEFONO";
            donanteTelefono.Width = 150;
            // 
            // lblBuscarDonante
            // 
            lblBuscarDonante.AutoSize = true;
            lblBuscarDonante.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscarDonante.Location = new Point(75, 34);
            lblBuscarDonante.Name = "lblBuscarDonante";
            lblBuscarDonante.Size = new Size(69, 20);
            lblBuscarDonante.TabIndex = 0;
            lblBuscarDonante.Text = "BUSCAR";
            // 
            // btnNuevoDonante
            // 
            btnNuevoDonante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoDonante.Location = new Point(736, 51);
            btnNuevoDonante.Name = "btnNuevoDonante";
            btnNuevoDonante.Size = new Size(151, 29);
            btnNuevoDonante.TabIndex = 3;
            btnNuevoDonante.Text = "NUEVO";
            btnNuevoDonante.UseVisualStyleBackColor = true;
            btnNuevoDonante.Click += btnNuevoDonante_Click;
            // 
            // btnDonanteSelect
            // 
            btnDonanteSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonanteSelect.Location = new Point(893, 51);
            btnDonanteSelect.Name = "btnDonanteSelect";
            btnDonanteSelect.Size = new Size(151, 29);
            btnDonanteSelect.TabIndex = 4;
            btnDonanteSelect.Text = "SELECT";
            btnDonanteSelect.UseVisualStyleBackColor = true;
            btnDonanteSelect.Click += btnDonanteSelect_Click;
            // 
            // frmDonanteLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 545);
            Controls.Add(btnDonanteSelect);
            Controls.Add(btnNuevoDonante);
            Controls.Add(gbxDonanteLista);
            Controls.Add(lblMantDonante);
            Name = "frmDonanteLista";
            Text = "LISTA DONANTE";
            Load += frmDonanteLista_Load;
            gbxDonanteLista.ResumeLayout(false);
            gbxDonanteLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMantDonante;
        private GroupBox gbxDonanteLista;
        private Button btnNuevoDonante;
        private Label lblBuscarDonante;
        private TextBox txtbxBuscarDonante;
        private ListView lstvwDonanteLista;
        private ColumnHeader donanteID;
        private ColumnHeader donanteNombre;
        private ColumnHeader donanteAp1;
        private ColumnHeader donanteAp2;
        private ColumnHeader donanteEmail;
        private ColumnHeader donanteTelefono;
        private CheckBox chkbxDonanteActivar;
        private ColumnHeader donanteTipoDon;
        private Button btnDonanteSelect;
    }
}
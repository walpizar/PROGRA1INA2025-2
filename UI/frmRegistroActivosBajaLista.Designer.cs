namespace UI
{
    partial class frmRegistroActivosBajaLista
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lstvRegistroBaja = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro de Activos dados de baja";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstvRegistroBaja);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Activos";
            // 
            // lstvRegistroBaja
            // 
            lstvRegistroBaja.GridLines = true;
            lstvRegistroBaja.Location = new Point(6, 42);
            lstvRegistroBaja.MultiSelect = false;
            lstvRegistroBaja.Name = "lstvRegistroBaja";
            lstvRegistroBaja.Size = new Size(458, 402);
            lstvRegistroBaja.TabIndex = 0;
            lstvRegistroBaja.UseCompatibleStateImageBehavior = false;
            // 
            // frmRegistroActivosBajaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 504);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmRegistroActivosBajaLista";
            Text = "frmRegistoActivosLista";
            Load += frmRegistroActivosBajaLista_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListView lstvRegistroBaja;
    }
}
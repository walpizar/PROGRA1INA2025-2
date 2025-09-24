namespace UI
{
    partial class frmDetalleDonacion
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
            gbxDetalleDonacionLista = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbxDetalleDonacionLista.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDetalleDonacionLista
            // 
            gbxDetalleDonacionLista.Controls.Add(tableLayoutPanel1);
            gbxDetalleDonacionLista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxDetalleDonacionLista.Location = new Point(12, 25);
            gbxDetalleDonacionLista.Name = "gbxDetalleDonacionLista";
            gbxDetalleDonacionLista.Size = new Size(512, 655);
            gbxDetalleDonacionLista.TabIndex = 9;
            gbxDetalleDonacionLista.TabStop = false;
            gbxDetalleDonacionLista.Text = "DETALLE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.4F));
            tableLayoutPanel1.Location = new Point(6, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(500, 620);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // frmDetalleDonacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 692);
            Controls.Add(gbxDetalleDonacionLista);
            Name = "frmDetalleDonacion";
            Text = "DETALLE DONACION";
            gbxDetalleDonacionLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDetalleDonacionLista;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
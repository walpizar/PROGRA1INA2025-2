namespace UI
{
    partial class frmDetallePagos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            apellido2 = new Label();
            apellido = new Label();
            listView1 = new ListView();
            nombre = new Label();
            correo = new Label();
            label9 = new Label();
            saldoPendiente = new Label();
            label12 = new Label();
            montoAnual = new Label();
            cbFrecuencia = new ComboBox();
            agregarPago = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(11, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "correo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(11, 84);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 9);
            label4.Name = "label4";
            label4.Size = new Size(203, 40);
            label4.TabIndex = 3;
            label4.Text = "Detalle Pagos";
            // 
            // apellido2
            // 
            apellido2.AutoSize = true;
            apellido2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            apellido2.Location = new Point(141, 84);
            apellido2.Name = "apellido2";
            apellido2.Size = new Size(50, 20);
            apellido2.TabIndex = 5;
            apellido2.Text = "label5";
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            apellido.Location = new Point(85, 85);
            apellido.Name = "apellido";
            apellido.Size = new Size(50, 20);
            apellido.TabIndex = 4;
            apellido.Text = "label6";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 194);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 187);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            nombre.Location = new Point(85, 63);
            nombre.Name = "nombre";
            nombre.Size = new Size(50, 20);
            nombre.TabIndex = 8;
            nombre.Text = "label7";
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            correo.Location = new Point(85, 105);
            correo.Name = "correo";
            correo.Size = new Size(50, 20);
            correo.TabIndex = 9;
            correo.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.Location = new Point(542, 82);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 10;
            label9.Text = "monto anual :";
            // 
            // saldoPendiente
            // 
            saldoPendiente.AutoSize = true;
            saldoPendiente.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            saldoPendiente.Location = new Point(649, 111);
            saldoPendiente.Name = "saldoPendiente";
            saldoPendiente.Size = new Size(45, 20);
            saldoPendiente.TabIndex = 13;
            saldoPendiente.Text = "saldo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.Location = new Point(520, 111);
            label12.Name = "label12";
            label12.Size = new Size(126, 20);
            label12.TabIndex = 12;
            label12.Text = "saldo pendiente :";
            // 
            // montoAnual
            // 
            montoAnual.AutoSize = true;
            montoAnual.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            montoAnual.Location = new Point(648, 82);
            montoAnual.Name = "montoAnual";
            montoAnual.Size = new Size(126, 20);
            montoAnual.TabIndex = 11;
            montoAnual.Text = "cantidad por ano";
            // 
            // cbFrecuencia
            // 
            cbFrecuencia.FormattingEnabled = true;
            cbFrecuencia.Location = new Point(12, 165);
            cbFrecuencia.Name = "cbFrecuencia";
            cbFrecuencia.Size = new Size(182, 23);
            cbFrecuencia.TabIndex = 14;
            // 
            // agregarPago
            // 
            agregarPago.Location = new Point(531, 387);
            agregarPago.Name = "agregarPago";
            agregarPago.Size = new Size(257, 39);
            agregarPago.TabIndex = 0;
            agregarPago.Text = "agregar un pago";
            agregarPago.UseVisualStyleBackColor = true;
            agregarPago.Click += btnAgregarPago_Click;
            // 
            // frmDetallePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarPago);
            Controls.Add(cbFrecuencia);
            Controls.Add(saldoPendiente);
            Controls.Add(label12);
            Controls.Add(montoAnual);
            Controls.Add(label9);
            Controls.Add(correo);
            Controls.Add(nombre);
            Controls.Add(listView1);
            Controls.Add(apellido2);
            Controls.Add(apellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetallePagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label apellido2;
        private Label apellido;
        private ListView listView1;
        private Label nombre;
        private Label correo;
        private Label label9;
        private Label saldoPendiente;
        private Label label12;
        private Label montoAnual;
        private ComboBox cbFrecuencia;
        private Button agregarPago;
    }
}
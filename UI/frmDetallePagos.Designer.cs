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
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 125);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "correo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 9);
            label4.Name = "label4";
            label4.Size = new Size(190, 40);
            label4.TabIndex = 3;
            label4.Text = "Detalle Pagos";
            // 
            // apellido2
            // 
            apellido2.AutoSize = true;
            apellido2.Location = new Point(143, 95);
            apellido2.Name = "apellido2";
            apellido2.Size = new Size(38, 15);
            apellido2.TabIndex = 5;
            apellido2.Text = "label5";
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(69, 95);
            apellido.Name = "apellido";
            apellido.Size = new Size(38, 15);
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
            nombre.Location = new Point(69, 61);
            nombre.Name = "nombre";
            nombre.Size = new Size(38, 15);
            nombre.TabIndex = 8;
            nombre.Text = "label7";
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Location = new Point(69, 125);
            correo.Name = "correo";
            correo.Size = new Size(38, 15);
            correo.TabIndex = 9;
            correo.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(547, 61);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 10;
            label9.Text = "monto anual :";
            // 
            // saldoPendiente
            // 
            saldoPendiente.AutoSize = true;
            saldoPendiente.Location = new Point(634, 95);
            saldoPendiente.Name = "saldoPendiente";
            saldoPendiente.Size = new Size(44, 15);
            saldoPendiente.TabIndex = 13;
            saldoPendiente.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(531, 95);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 12;
            label12.Text = "saldo pendiente :";
            // 
            // montoAnual
            // 
            montoAnual.AutoSize = true;
            montoAnual.Location = new Point(634, 61);
            montoAnual.Name = "montoAnual";
            montoAnual.Size = new Size(74, 15);
            montoAnual.TabIndex = 11;
            montoAnual.Text = "Pago Anual :";
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
            Load += frmDetallePagos_Load_1;
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
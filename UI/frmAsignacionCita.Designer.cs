namespace UI
{
    partial class frmAsignacionCita
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
            lblTitulo = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            textPaciente = new TextBox();
            label2 = new Label();
            combMedico = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateCita = new DateTimePicker();
            textHora = new TextBox();
            richTextBox1 = new RichTextBox();
            btnAsiganar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(241, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(312, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Asiganción de Citas";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 147);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Paciente:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // textPaciente
            // 
            textPaciente.Location = new Point(194, 147);
            textPaciente.Name = "textPaciente";
            textPaciente.Size = new Size(359, 31);
            textPaciente.TabIndex = 1;
            textPaciente.MouseClick += textPaciente_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 204);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "Medico:";
            // 
            // combMedico
            // 
            combMedico.FormattingEnabled = true;
            combMedico.Location = new Point(194, 201);
            combMedico.Name = "combMedico";
            combMedico.Size = new Size(359, 33);
            combMedico.TabIndex = 2;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 251);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 301);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 7;
            label4.Text = "Hora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 357);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 9;
            label5.Text = "Motivo:";
            // 
            // dateCita
            // 
            dateCita.Location = new Point(194, 251);
            dateCita.Name = "dateCita";
            dateCita.Size = new Size(359, 31);
            dateCita.TabIndex = 3;
            // 
            // textHora
            // 
            textHora.Location = new Point(194, 298);
            textHora.Name = "textHora";
            textHora.Size = new Size(359, 31);
            textHora.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(194, 357);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(359, 121);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // btnAsiganar
            // 
            btnAsiganar.Location = new Point(505, 596);
            btnAsiganar.Name = "btnAsiganar";
            btnAsiganar.Size = new Size(131, 47);
            btnAsiganar.TabIndex = 16;
            btnAsiganar.Text = "Asignar";
            btnAsiganar.UseVisualStyleBackColor = true;
            btnAsiganar.Click += btnAsiganar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(662, 596);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 47);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAsignacionCita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 655);
            Controls.Add(btnCancelar);
            Controls.Add(btnAsiganar);
            Controls.Add(richTextBox1);
            Controls.Add(textHora);
            Controls.Add(dateCita);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(combMedico);
            Controls.Add(label2);
            Controls.Add(textPaciente);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "frmAsignacionCita";
            Text = "Citas";
            Load += frmAsignacionCita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textPaciente;
        private Label label2;
        private ComboBox combMedico;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateCita;
        private TextBox textHora;
        private RichTextBox richTextBox1;
        private Button btnAsiganar;
        private Button btnCancelar;
    }
}
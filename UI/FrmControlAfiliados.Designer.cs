namespace UI
{
    partial class FrmControlAfiliados
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
            listView1 = new ListView();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 37);
            label1.TabIndex = 0;
            label1.Text = "Control Aportes de Afiliados";
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 172);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 266);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(521, 143);
            button1.Name = "button1";
            button1.Size = new Size(267, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 23);
            textBox1.TabIndex = 3;
            // 
            // FrmControlAfiliados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "FrmControlAfiliados";
            Text = "FrmControlAfiliados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private TextBox textBox1;
    }
}
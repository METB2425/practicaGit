namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTelegrama = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            btnCalcularPrecio = new Button();
            rbOrdinario = new RadioButton();
            rbUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(63, 37);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(378, 142);
            txtTelegrama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 273);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 280);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Coste";
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(269, 229);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(172, 71);
            btnCalcularPrecio.TabIndex = 5;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Checked = true;
            rbOrdinario.Location = new Point(63, 198);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(93, 24);
            rbOrdinario.TabIndex = 6;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(63, 229);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(83, 24);
            rbUrgente.TabIndex = 7;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 341);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
        private Button btnCalcularPrecio;
        private RadioButton rbOrdinario;
        private RadioButton rbUrgente;
    }
}

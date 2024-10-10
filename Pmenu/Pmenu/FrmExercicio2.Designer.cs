namespace Pmenu
{
    partial class FrmExercicio2
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
            lblPalavra1 = new Label();
            lblPalavra2 = new Label();
            btnIguais = new Button();
            btnInserir1 = new Button();
            btnInserir2 = new Button();
            txtPalavra1 = new TextBox();
            txtPalavra2 = new TextBox();
            SuspendLayout();
            // 
            // lblPalavra1
            // 
            lblPalavra1.AutoSize = true;
            lblPalavra1.Location = new Point(72, 58);
            lblPalavra1.Name = "lblPalavra1";
            lblPalavra1.Size = new Size(54, 15);
            lblPalavra1.TabIndex = 0;
            lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            lblPalavra2.AutoSize = true;
            lblPalavra2.Location = new Point(72, 131);
            lblPalavra2.Name = "lblPalavra2";
            lblPalavra2.Size = new Size(54, 15);
            lblPalavra2.TabIndex = 1;
            lblPalavra2.Text = "Palavra 2";
            // 
            // btnIguais
            // 
            btnIguais.Location = new Point(91, 233);
            btnIguais.Name = "btnIguais";
            btnIguais.Size = new Size(132, 63);
            btnIguais.TabIndex = 2;
            btnIguais.Text = "Compara Iguais";
            btnIguais.UseVisualStyleBackColor = true;
            btnIguais.Click += btnIguais_Click;
            // 
            // btnInserir1
            // 
            btnInserir1.Location = new Point(281, 233);
            btnInserir1.Name = "btnInserir1";
            btnInserir1.Size = new Size(100, 63);
            btnInserir1.TabIndex = 3;
            btnInserir1.Text = "Inserir 1º no meio do 2º";
            btnInserir1.UseVisualStyleBackColor = true;
            btnInserir1.Click += btnInserir1_Click;
            // 
            // btnInserir2
            // 
            btnInserir2.Location = new Point(408, 233);
            btnInserir2.Name = "btnInserir2";
            btnInserir2.Size = new Size(104, 63);
            btnInserir2.TabIndex = 4;
            btnInserir2.Text = "Inserir 2 asteriscos no meio do 1º";
            btnInserir2.UseVisualStyleBackColor = true;
            btnInserir2.Click += btnInserir2_Click;
            // 
            // txtPalavra1
            // 
            txtPalavra1.Location = new Point(175, 58);
            txtPalavra1.Name = "txtPalavra1";
            txtPalavra1.Size = new Size(100, 23);
            txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            txtPalavra2.Location = new Point(175, 123);
            txtPalavra2.Name = "txtPalavra2";
            txtPalavra2.Size = new Size(100, 23);
            txtPalavra2.TabIndex = 6;
            // 
            // FrmExercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 701);
            Controls.Add(txtPalavra2);
            Controls.Add(txtPalavra1);
            Controls.Add(btnInserir2);
            Controls.Add(btnInserir1);
            Controls.Add(btnIguais);
            Controls.Add(lblPalavra2);
            Controls.Add(lblPalavra1);
            Name = "FrmExercicio2";
            Text = "FrmExercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalavra1;
        private Label lblPalavra2;
        private Button btnIguais;
        private Button btnInserir1;
        private Button btnInserir2;
        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
    }
}
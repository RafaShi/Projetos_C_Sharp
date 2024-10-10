namespace Pmenu
{
    partial class FrmExercicio3_
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
            txtPalavra2 = new TextBox();
            txtPalavra1 = new TextBox();
            btnInverter = new Button();
            btnRemover = new Button();
            lblPalavra2 = new Label();
            lblPalavra1 = new Label();
            SuspendLayout();
            // 
            // txtPalavra2
            // 
            txtPalavra2.Enabled = false;
            txtPalavra2.Location = new Point(283, 171);
            txtPalavra2.Name = "txtPalavra2";
            txtPalavra2.Size = new Size(100, 23);
            txtPalavra2.TabIndex = 13;
            // 
            // txtPalavra1
            // 
            txtPalavra1.Location = new Point(283, 106);
            txtPalavra1.Name = "txtPalavra1";
            txtPalavra1.Size = new Size(100, 23);
            txtPalavra1.TabIndex = 12;
            // 
            // btnInverter
            // 
            btnInverter.Location = new Point(389, 281);
            btnInverter.Name = "btnInverter";
            btnInverter.Size = new Size(100, 63);
            btnInverter.TabIndex = 10;
            btnInverter.Text = "Inverter 1º";
            btnInverter.UseVisualStyleBackColor = true;
            btnInverter.Click += btnInverter_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(199, 281);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(135, 63);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblPalavra2
            // 
            lblPalavra2.AutoSize = true;
            lblPalavra2.Location = new Point(180, 179);
            lblPalavra2.Name = "lblPalavra2";
            lblPalavra2.Size = new Size(54, 15);
            lblPalavra2.TabIndex = 8;
            lblPalavra2.Text = "Palavra 2";
            // 
            // lblPalavra1
            // 
            lblPalavra1.AutoSize = true;
            lblPalavra1.Location = new Point(180, 106);
            lblPalavra1.Name = "lblPalavra1";
            lblPalavra1.Size = new Size(54, 15);
            lblPalavra1.TabIndex = 7;
            lblPalavra1.Text = "Palavra 1";
            // 
            // FrmExercicio3_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPalavra2);
            Controls.Add(txtPalavra1);
            Controls.Add(btnInverter);
            Controls.Add(btnRemover);
            Controls.Add(lblPalavra2);
            Controls.Add(lblPalavra1);
            Name = "FrmExercicio3_";
            Text = "FrmExercicio3_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalavra2;
        private TextBox txtPalavra1;
        private Button btnInverter;
        private Button btnRemover;
        private Label lblPalavra2;
        private Label lblPalavra1;
    }
}
namespace Pmenu
{
    partial class FrmExercicio5
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSorteio = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(158, 157);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(157, 39);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(420, 157);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(157, 39);
            txtNum2.TabIndex = 1;
            // 
            // btnSorteio
            // 
            btnSorteio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSorteio.Location = new Point(297, 257);
            btnSorteio.Name = "btnSorteio";
            btnSorteio.Size = new Size(149, 73);
            btnSorteio.TabIndex = 2;
            btnSorteio.Text = "Sorteio";
            btnSorteio.UseVisualStyleBackColor = true;
            btnSorteio.Click += btnSorteio_Click;
            // 
            // FrmExercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSorteio);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "FrmExercicio5";
            Text = "FrmExercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSorteio;
    }
}
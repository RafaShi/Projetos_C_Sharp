namespace Pclasses
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
            btnMensalista = new Button();
            btnHorista = new Button();
            SuspendLayout();
            // 
            // btnMensalista
            // 
            btnMensalista.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMensalista.Location = new Point(171, 211);
            btnMensalista.Name = "btnMensalista";
            btnMensalista.Size = new Size(125, 45);
            btnMensalista.TabIndex = 0;
            btnMensalista.Text = "Mensalista";
            btnMensalista.UseVisualStyleBackColor = true;
            btnMensalista.Click += btnMensalista_Click;
            // 
            // btnHorista
            // 
            btnHorista.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHorista.Location = new Point(530, 211);
            btnHorista.Name = "btnHorista";
            btnHorista.Size = new Size(125, 45);
            btnHorista.TabIndex = 1;
            btnHorista.Text = "Horista";
            btnHorista.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 477);
            Controls.Add(btnHorista);
            Controls.Add(btnMensalista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensalista;
        private Button btnHorista;
    }
}

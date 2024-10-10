namespace Pmenu
{
    partial class FrmExercicio4
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
            rchtxtFrase = new RichTextBox();
            btnContar = new Button();
            btnEspacoEmBranco = new Button();
            btnContarLetras = new Button();
            SuspendLayout();
            // 
            // rchtxtFrase
            // 
            rchtxtFrase.Location = new Point(301, 37);
            rchtxtFrase.Name = "rchtxtFrase";
            rchtxtFrase.Size = new Size(100, 96);
            rchtxtFrase.TabIndex = 0;
            rchtxtFrase.Text = "";
            // 
            // btnContar
            // 
            btnContar.Location = new Point(115, 256);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(140, 59);
            btnContar.TabIndex = 1;
            btnContar.Text = "Contar Número";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnEspacoEmBranco
            // 
            btnEspacoEmBranco.Location = new Point(318, 251);
            btnEspacoEmBranco.Name = "btnEspacoEmBranco";
            btnEspacoEmBranco.Size = new Size(100, 64);
            btnEspacoEmBranco.TabIndex = 2;
            btnEspacoEmBranco.Text = "1º espaço em branco";
            btnEspacoEmBranco.UseVisualStyleBackColor = true;
            btnEspacoEmBranco.Click += btnEspacoEmBranco_Click;
            // 
            // btnContarLetras
            // 
            btnContarLetras.Location = new Point(453, 251);
            btnContarLetras.Name = "btnContarLetras";
            btnContarLetras.Size = new Size(130, 64);
            btnContarLetras.TabIndex = 3;
            btnContarLetras.Text = "Contar Letras";
            btnContarLetras.UseVisualStyleBackColor = true;
            btnContarLetras.Click += btnContarLetras_Click;
            // 
            // FrmExercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContarLetras);
            Controls.Add(btnEspacoEmBranco);
            Controls.Add(btnContar);
            Controls.Add(rchtxtFrase);
            Name = "FrmExercicio4";
            Text = "FrmExercicio4";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rchtxtFrase;
        private Button btnContar;
        private Button btnEspacoEmBranco;
        private Button btnContarLetras;
    }
}
namespace Ploops
{
    partial class FrmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnParLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(289, 84);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(200, 57);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(130, 271);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(97, 37);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(353, 271);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(97, 37);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnParLetra
            // 
            this.btnParLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParLetra.Location = new System.Drawing.Point(533, 271);
            this.btnParLetra.Name = "btnParLetra";
            this.btnParLetra.Size = new System.Drawing.Size(162, 37);
            this.btnParLetra.TabIndex = 3;
            this.btnParLetra.Text = "Par de letras";
            this.btnParLetra.UseVisualStyleBackColor = true;
            this.btnParLetra.Click += new System.EventHandler(this.btnParLetra_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetra);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnParLetra;
    }
}
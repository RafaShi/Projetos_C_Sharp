namespace Pclasses
{
    partial class frmMensalista
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
            txtMatricula = new TextBox();
            txtSalarioMensal = new TextBox();
            txtDataEntrada = new TextBox();
            txtNome = new TextBox();
            btnInstanciar1 = new Button();
            btnInstanciar2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 134);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario Mensal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 168);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(247, 51);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 4;
            // 
            // txtSalarioMensal
            // 
            txtSalarioMensal.Location = new Point(247, 126);
            txtSalarioMensal.Name = "txtSalarioMensal";
            txtSalarioMensal.Size = new Size(100, 23);
            txtSalarioMensal.TabIndex = 5;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Location = new Point(247, 168);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(100, 23);
            txtDataEntrada.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(247, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 8;
            // 
            // btnInstanciar1
            // 
            btnInstanciar1.Location = new Point(62, 248);
            btnInstanciar1.Name = "btnInstanciar1";
            btnInstanciar1.Size = new Size(134, 54);
            btnInstanciar1.TabIndex = 9;
            btnInstanciar1.Text = "Instanciar Mensalista";
            btnInstanciar1.UseVisualStyleBackColor = true;
            btnInstanciar1.Click += btnInstanciar1_Click;
            // 
            // btnInstanciar2
            // 
            btnInstanciar2.Location = new Point(280, 248);
            btnInstanciar2.Name = "btnInstanciar2";
            btnInstanciar2.Size = new Size(134, 54);
            btnInstanciar2.TabIndex = 10;
            btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            btnInstanciar2.UseVisualStyleBackColor = true;
            btnInstanciar2.Click += btnInstanciar2_Click;
            // 
            // frmMensalista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInstanciar2);
            Controls.Add(btnInstanciar1);
            Controls.Add(txtNome);
            Controls.Add(txtDataEntrada);
            Controls.Add(txtSalarioMensal);
            Controls.Add(txtMatricula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMensalista";
            Text = "frmMensalista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatricula;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtDataEntrada;
        private TextBox txtSalarioMensal;
        private TextBox txtNome;
        private Button btnInstanciar1;
        private Button btnInstanciar2;
    }
}
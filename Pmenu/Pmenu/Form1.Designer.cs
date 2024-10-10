namespace Pmenu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            exercício2ToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            exercício3ToolStripMenuItem = new ToolStripMenuItem();
            exercício4ToolStripMenuItem = new ToolStripMenuItem();
            exercício5ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            altToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercício2ToolStripMenuItem, exercício3ToolStripMenuItem, exercício4ToolStripMenuItem, exercício5ToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercício2ToolStripMenuItem
            // 
            exercício2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem });
            exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            exercício2ToolStripMenuItem.Size = new Size(75, 20);
            exercício2ToolStripMenuItem.Text = "Exercício &2";
            exercício2ToolStripMenuItem.Click += exercício2ToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(151, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(151, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // exercício3ToolStripMenuItem
            // 
            exercício3ToolStripMenuItem.Name = "exercício3ToolStripMenuItem";
            exercício3ToolStripMenuItem.Size = new Size(75, 20);
            exercício3ToolStripMenuItem.Text = "Exercício &3";
            exercício3ToolStripMenuItem.Click += exercício3ToolStripMenuItem_Click;
            // 
            // exercício4ToolStripMenuItem
            // 
            exercício4ToolStripMenuItem.Name = "exercício4ToolStripMenuItem";
            exercício4ToolStripMenuItem.Size = new Size(75, 20);
            exercício4ToolStripMenuItem.Text = "Exercício &4";
            exercício4ToolStripMenuItem.Click += exercício4ToolStripMenuItem_Click;
            // 
            // exercício5ToolStripMenuItem
            // 
            exercício5ToolStripMenuItem.Name = "exercício5ToolStripMenuItem";
            exercício5ToolStripMenuItem.Size = new Size(75, 20);
            exercício5ToolStripMenuItem.Text = "Exercício &5";
            exercício5ToolStripMenuItem.Click += exercício5ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altToolStripMenuItem, sairToolStripMenuItem1 });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // altToolStripMenuItem
            // 
            altToolStripMenuItem.Name = "altToolStripMenuItem";
            altToolStripMenuItem.Size = new Size(135, 22);
            altToolStripMenuItem.Text = "Alt + ";
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem1.Size = new Size(135, 22);
            sairToolStripMenuItem1.Text = "Sair";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editorDeTextoToolStripMenuItem, calculadoraToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 48);
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(151, 22);
            editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(151, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 745);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercício2ToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem exercício3ToolStripMenuItem;
        private ToolStripMenuItem exercício4ToolStripMenuItem;
        private ToolStripMenuItem exercício5ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem altToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
    }
}

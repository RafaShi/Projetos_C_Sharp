using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ploops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() >0) 
            {
                MessageBox.Show("O forms já existe");
                Application.OpenForms["FrmExercico1"].BringToFront();
            }
            else
            {
                FrmExercicio1 obj1 = new FrmExercicio1();
                obj1.MdiParent = this; 
                obj1.WindowState = FormWindowState.Maximized;  
                obj1.Show();
            }
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio2>().Count() > 0)
            {
                MessageBox.Show("O forms já existe");
                Application.OpenForms["FrmExercico2"].BringToFront();
            }
            else
            {
                FrmExercicio2 obj2 = new FrmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void exercicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio3>().Count() > 0)
            {
                MessageBox.Show("O forms já existe");
                Application.OpenForms["FrmExercico3"].BringToFront();
            }
            else
            {
                FrmExercicio3 obj3 = new FrmExercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio4>().Count() > 0)
            {
                MessageBox.Show("O forms já existe");
                Application.OpenForms["FrmExercico4"].BringToFront();
            }
            else
            {
                FrmExercicio4 obj4 = new FrmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }
    }
}

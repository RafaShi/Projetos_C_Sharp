namespace Pmenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção colar");
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se o forms não tem nada
                Application.OpenForms["FrmExercicio2"].BringToFront();
            }
            else
            {
                FrmExercicio2 obj2 = new FrmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();

            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FrmExercicio3_>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se o forms não tem nada
                Application.OpenForms["FrmExercicio3_"].BringToFront();
            }
            else
            {
                FrmExercicio3_ obj3 = new FrmExercicio3_();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se o forms não tem nada
                Application.OpenForms["FrmExercicio4"].BringToFront();
            }
            else
            {
                FrmExercicio4 obj4 = new FrmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se o forms não tem nada
                Application.OpenForms["FrmExercicio5"].BringToFront();
            }
            else
            {
                FrmExercicio5 obj5 = new FrmExercicio5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Maximized;
                obj5.Show();
            }
        }
    }
}

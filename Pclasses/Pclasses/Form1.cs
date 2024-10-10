namespace Pclasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            frmMensalista objMensalista = new frmMensalista();
            objMensalista.ShowDialog();

        }
    }
}

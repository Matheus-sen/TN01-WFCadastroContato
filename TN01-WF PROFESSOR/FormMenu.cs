namespace TN01_WFPROFESSOR
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormContato form = new FormContato();
            form.ShowDialog();
        }

        private void mnsSobre_Click(object sender, EventArgs e)
        {

        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }
    }
}

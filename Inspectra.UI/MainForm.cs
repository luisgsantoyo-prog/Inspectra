namespace Inspectra.UI
{
    public partial class MainForm : Form
    {
        private EquipmentForm? equipmentForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (equipmentForm == null || equipmentForm.IsDisposed)
            {
                equipmentForm = new EquipmentForm();

                equipmentForm.MdiParent = this;
                equipmentForm.WindowState = FormWindowState.Maximized;
                equipmentForm.Show();
            }

        }
    }
}

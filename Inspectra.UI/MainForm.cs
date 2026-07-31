namespace Inspectra.UI
{
    public partial class MainForm : Form
    {
        private EquipmentManagerForm? equipmentManagerForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (equipmentManagerForm == null || equipmentManagerForm.IsDisposed)
            {
                equipmentManagerForm = new EquipmentManagerForm();

                equipmentManagerForm.MdiParent = this;
                equipmentManagerForm.WindowState = FormWindowState.Maximized;
                equipmentManagerForm.Show();
            }
        else
            { 
                equipmentManagerForm.Activate(); 
            }
        }
    }
}

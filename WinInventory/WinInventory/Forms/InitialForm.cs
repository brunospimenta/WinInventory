using FontAwesome.Sharp;

namespace WinInventory.Forms
{
    public partial class InitialForm : Form
    {
        #region Global var's

        private Form currentChildForm;

        #endregion

        public InitialForm()
        {
            InitializeComponent();
            OpenChildForm(new ReportForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.BackColor = Color.PaleGoldenrod;
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childrenFormArea.Controls.Add(childForm);
            childrenFormArea.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childFormLabel.Text = childForm.Text;
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportForm());
        }

        private void ViewerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewerForm());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinInventory.Utils;

namespace WinInventory.Forms
{
    public partial class CreateUser : Form
    {
        public string user;
        public CreateUser()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            user = userTextBox.Text;

            CredentialsCreator.createUsernameFile(user);
            this.Close();
        }
    }
}

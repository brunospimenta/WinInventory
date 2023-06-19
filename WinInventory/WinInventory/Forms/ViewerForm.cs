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
    public partial class ViewerForm : Form
    {
        

        #region buttons hide and show

        #endregion

        public ViewerForm()
        {
            InitializeComponent();
            tab1.Text = "Audio Device";
            tab2.Text = "Network Adapter";
            tab3.Text = "Others";
            richTextBox1.Text = Reader.InfoReader("Sound_Devices");
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text == "Audio Device")
            {
                richTextBox1.Text = Reader.InfoReader("Sound_Devices");
            }
            if(tabControl.SelectedTab.Text == "Network Adapter")
            {
                richTextBox1.Text = Reader.InfoReader("Adapters");
            }
            if(tabControl.SelectedTab.Text == "Others")
            {
                richTextBox1.Text = Reader.InfoReader("USB_Devices");
            }
            
        }

        private void hardwareBtn_Click(object sender, EventArgs e)
        {
            tabControl.Show();
            richTextBox1.Text = "";
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            tabControl.Hide();
            richTextBox1.Text = "";
        }

        private void devicesBtn_Click(object sender, EventArgs e)
        {

        }

        private void applicationsBtn_Click(object sender, EventArgs e)
        {

        }

        private void driversBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

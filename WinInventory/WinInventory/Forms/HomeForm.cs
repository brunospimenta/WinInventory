using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinInventory.Models;
using WinInventory.Utils;

namespace WinInventory.Forms
{
    public partial class HomeForm : Form
    {

        #region var's
        public SecureString pwd = new SecureString();
        int pwdLength;
        string InfoDirectory;
        string user;
        #endregion

        public HomeForm()
        {
            InitializeComponent();

            FolderCreator.Create();

            InfoDirectory = PathFinder.solutionDirectory().ToString() + @"\infos\";
            pwdLength = Directory.GetFiles(InfoDirectory).Count();
            user = Reader.UserOrPassReader("user");

            if(!File.Exists(InfoDirectory + "user.txt"))
            {
                Form CreateUser = new CreateUser();
                CreateUser.Show();
            }

            GetPass();
        }

        #region methods
        private SecureString GetPass()
        {
            for(int i = 0; i< pwdLength - 1; i++) 
            {
                string pass = Reader.UserOrPassReader($"{i}");
                char ch = char.Parse(pass);
                pwd.AppendChar(ch);
            }
            return pwd;
        }

        #endregion

        #region buttons
        private void BtnGeral_Click(object sender, EventArgs e)
        {

        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {

        }

        private void BtnDevices_Click(object sender, EventArgs e)
        {

        }

        private void BtnDrivers_Click(object sender, EventArgs e)
        {

        }

        private void BtnHardware_Click(object sender, EventArgs e)
        {

        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            Geral geral = new Geral();

            Stopwatch tempoGeral = new Stopwatch();
            tempoGeral.Start();

            var teste = ThreadCmd.comando("ipconfig | find \"IPv4\"", "IP", user, pwd);

            tempoGeral.Stop();

            geral.ExecutionTime = tempoGeral.ElapsedMilliseconds / 1000;
        }
        #endregion
    }
}

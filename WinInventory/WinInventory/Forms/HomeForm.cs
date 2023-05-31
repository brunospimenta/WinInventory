using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinInventory.Models;
using WinInventory.Models.OneByOne;
using WinInventory.Utils;

namespace WinInventory.Forms
{
    public partial class HomeForm : Form
    {

        #region configs var
        public SecureString pwd = new SecureString();
        int pwdLength;
        string InfoDirectory;
        string user;
        double exitTimer;
        bool timerReset = true;
        #endregion

        #region Models var
        Applications apps = new Applications();
        Devices devices = new Devices();
        SystemInfo systemInfo = new SystemInfo();
        Drivers drivers = new Drivers();
        Hardware hardware = new Hardware();
        Geral geral = new Geral();
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
            if (!timerReset)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                geral.DeviceId = ThreadCmd.comando("wmic os get serialnumber", "Device_ID", user, pwd);
                timer.Stop();
            }
            
        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            apps.AllApplications = ThreadCmd.comando("wmic product get name, version, installDate", "Applications", user, pwd);
            timer.Stop();
            exitTimer += timer.ElapsedMilliseconds / 1000;

            MessageBox.Show(exitTimer.ToString() + " seconds");
        }

        private void BtnDevices_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            devices.AudioDevice = ThreadCmd.comando("wmic path win32_SoundDevice get name", "Sound_Devices", user, pwd);
            devices.NetworkAdapter = ThreadCmd.comando("wmic nic get AdapterType, Name, Installed", "Adapters", user, pwd);
            devices.Others = ThreadCmd.comando("pnputil /enum-devices | findstr USB", "USB_Devices", user, pwd);
            timer.Stop();

            exitTimer += timer.ElapsedMilliseconds / 1000;

            MessageBox.Show(exitTimer.ToString() + " seconds");
        }

        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            
            Stopwatch timer = new Stopwatch();
            timer.Start();
            drivers.AntiVirus = ThreadCmd.comando("wmic /Node:localhost/Namespace:\\\\root\\SecurityCenter2 Path AntiVirusProduct Get displayName",
                "AntiVirus", user, pwd);
            drivers.Firewall = ThreadCmd.comando("netsh advfirewall show allprofiles", "Firewall", user, pwd);
            drivers.Proxy = ThreadCmd.comando("netsh winhttp show proxy", "Proxy", user, pwd);
            timer.Stop();

            exitTimer += timer.ElapsedMilliseconds/1000;

            MessageBox.Show(exitTimer.ToString());
        }

        private void BtnHardware_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            hardware.ManufacturerAndModel = ThreadCmd.comando("wmic computersystem get model, manufacturerd", "ManufacturerAndModel", user, pwd);
            hardware.Display = ThreadCmd.comando("wmic desktopmonitor get Name,MonitorType,MonitorManufacturer", "Sound_Devices", user, pwd);
            hardware.GraphicCard = ThreadCmd.comando("wmic path win32_VideoController get name", "Sound_Devices", user, pwd);
            hardware.HardDisk = ThreadCmd.comando("wmic diskdrive get model, size", "Sound_Devices", user, pwd);
            hardware.MotherBoard = ThreadCmd.comando("wmic baseboard get product, Manufacturer", "MotherBoard", user, pwd);
            hardware.Processor = ThreadCmd.comando("wmic cpu get name", "Sound_Devices", user, pwd);
            hardware.ProductID = ThreadCmd.comando("systeminfo | findstr \"Product ID\"", "Sound_Devices", user, pwd);
            hardware.mRam = ThreadCmd.comando("systeminfo | find \"Total Physical Memory\"", "Sound_Devices", user, pwd);

            timer.Stop();

            exitTimer += timer.ElapsedMilliseconds / 1000;

            MessageBox.Show(exitTimer.ToString());
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            systemInfo.Domain = ThreadCmd.comando("systeminfo | find \"Domain\"", "Sound_Devices", user, pwd);
            systemInfo.Hostname = ThreadCmd.comando("hostname", "Sound_Devices", user, pwd);
            systemInfo.IP = ThreadCmd.comando("ipconfig | find \"IPv4 Address\"", "Sound_Devices", user, pwd);
            systemInfo.LastUserName = ThreadCmd.comando("whoami", "Sound_Devices", user, pwd);
            systemInfo.OS = ThreadCmd.comando("systeminfo | find \"OS Name\"", "Sound_Devices", user, pwd);
            systemInfo.InstallDate =  ThreadCmd.comando("systeminfo | find \"Original Install Date\"", "Sound_Devices", user, pwd);
            systemInfo.FirstSync = DateTime.Now;

            timer.Stop();

            exitTimer += timer.ElapsedMilliseconds / 1000;

            MessageBox.Show(exitTimer.ToString());
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

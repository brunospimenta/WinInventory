using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        double geralExitTimer;
        double individualExitTimer;
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

            try
            {
                if (!File.Exists(InfoDirectory + "user.txt"))
                {
                    Form CreateUser = new CreateUser();
                    CreateUser.Show();
                }

                GetPass();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private string GetLocale()
        {
            CultureInfo ci = CultureInfo.CurrentUICulture;
            var language = ci.Name;

            return language;
        }

        #endregion

        #region buttons
        private void BtnGeral_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                geral.DeviceId = ThreadCmd.comando("wmic os get serialnumber", "Device_ID", user, pwd);

                timer.Stop();

                geralExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex) 
            {
                MessageBox.Show("Error Creating Geral relatory" + ex.Message);
            }
            
        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                apps.AllApplications = ThreadCmd.comando("wmic product get name, version, installDate", "Applications", user, pwd);
                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex )
            {
                MessageBox.Show("Error Creating Apllications relatory" + ex.Message);
            }
            

        }

        private void BtnDevices_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                devices.AudioDevice = ThreadCmd.comando("wmic path win32_SoundDevice get name", "Sound_Devices", user, pwd);
                devices.NetworkAdapter = ThreadCmd.comando("wmic nic get AdapterType, Name, Installed", "Adapters", user, pwd);
                devices.Others = ThreadCmd.comando("pnputil /enum-devices | findstr USB", "USB_Devices", user, pwd);
                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex)
            {
                MessageBox.Show("Error creating Devices relatory" + ex.Message);
            }
        }

        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                drivers.AntiVirus = ThreadCmd.comando("wmic /Node:localhost/Namespace:\\\\root\\SecurityCenter2 Path AntiVirusProduct Get displayName",
                    "AntiVirus", user, pwd);
                drivers.Firewall = ThreadCmd.comando("netsh advfirewall show allprofiles", "Firewall", user, pwd);
                drivers.Proxy = ThreadCmd.comando("netsh winhttp show proxy", "Proxy", user, pwd);
                timer.Stop();

                individualExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex ) 
            {
                MessageBox.Show("Error creating Drivers relatory" + ex.Message);
            }
            

        }
        private void BtnHardware_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();

                if(GetLocale() == "en-US")
                {
                    hardware.ProductID = ThreadCmd.comando("systeminfo | findstr \"Product ID\"", "Product_ID", user, pwd);
                    hardware.mRam = ThreadCmd.comando("systeminfo | find \"Total Physical Memory\"", "mRam", user, pwd);
                }
                else
                {
                    hardware.ProductID = ThreadCmd.comando("systeminfo | findstr \"Identificação do produto\"", "Product_ID", user, pwd);
                    hardware.mRam = ThreadCmd.comando("systeminfo | find \"Memória física total\"", "mRam", user, pwd);
                }
                hardware.ManufacturerAndModel = ThreadCmd.comando("wmic computersystem get manufacturer", "ManufacturerAndModel", user, pwd);
                hardware.Display = ThreadCmd.comando("wmic desktopmonitor get Name,MonitorType,MonitorManufacturer", "Displays", user, pwd);
                hardware.GraphicCard = ThreadCmd.comando("wmic path win32_VideoController get name", "GraphicCard", user, pwd);
                hardware.HardDisk = ThreadCmd.comando("wmic diskdrive get model, size", "HD", user, pwd);
                hardware.MotherBoard = ThreadCmd.comando("wmic baseboard get product, Manufacturer", "MotherBoard", user, pwd);
                hardware.Processor = ThreadCmd.comando("wmic cpu get name", "Processor", user, pwd);
                

                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex)
            {
                MessageBox.Show("Error creating Hardware relatory" + ex.Message);
            }
            
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetLocale() == "en-US")
                {
                    systemInfo.Domain = ThreadCmd.comando("systeminfo | find \"Domain\"", "Domain", user, pwd);
                    systemInfo.IP = ThreadCmd.comando("ipconfig | find \"IPv4 Address\"", "IP", user, pwd);
                    systemInfo.OS = ThreadCmd.comando("systeminfo | find \"OS Name\"", "OS", user, pwd);
                    systemInfo.InstallDate = ThreadCmd.comando("systeminfo | find \"Original Install Date\"", "InstallDate", user, pwd);
                }
                else
                {
                    systemInfo.Domain = ThreadCmd.comando("systeminfo | find \"Domínio\"", "Domain", user, pwd);
                    systemInfo.IP = ThreadCmd.comando("ipconfig | find \"Endereço IPv4\"", "IP", user, pwd);
                    systemInfo.OS = ThreadCmd.comando("systeminfo | find \"Nome do sistema operacional\"", "OS", user, pwd);
                    systemInfo.InstallDate = ThreadCmd.comando("systeminfo | find \"Data de instalação original\"", "InstallDate", user, pwd);
                }

                Stopwatch timer = new Stopwatch();
                timer.Start();
                
                systemInfo.Hostname = ThreadCmd.comando("hostname", "Hostname", user, pwd);
                systemInfo.LastUserName = ThreadCmd.comando("whoami", "LastUser", user, pwd);
                systemInfo.FirstSync = DateTime.Now;

                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex)
            {
                MessageBox.Show("Error creating System relatory" + ex.Message);
            }
            
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetLocale());
        }
        #endregion
    }
}

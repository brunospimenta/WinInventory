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

                #region (Applications) escrita dos txts e leitura/vinculo ao Model

                ThreadCmd.comando("wmic product get name, version, installDate", "Applications", user, pwd);
                apps.AllApplications = Reader.InfoReader("Applications");

                #endregion

                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
                geralExitTimer  += timer.ElapsedMilliseconds / 1000;
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

                #region (Devices) escrita dos txts e leitura/vinculo ao Model

                ThreadCmd.comando("wmic path win32_SoundDevice get name", "Sound_Devices", user, pwd);
                devices.AudioDevice = Reader.InfoReader("Sound_Devices");
                ThreadCmd.comando("wmic nic get AdapterType, Name, Installed", "Adapters", user, pwd);
                devices.NetworkAdapter = Reader.InfoReader("Adapters");
                ThreadCmd.comando("pnputil /enum-devices | findstr USB", "USB_Devices", user, pwd);
                devices.Others = Reader.InfoReader("USB_Devices");

                #endregion

                timer.Stop();
                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
                geralExitTimer += timer.ElapsedMilliseconds / 1000;
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

                #region (Drivers) escrita dos txts e leitura/vinculo ao Model

                ThreadCmd.comando("wmic /Node:localhost/Namespace:\\\\root\\SecurityCenter2 Path AntiVirusProduct Get displayName",
                    "AntiVirus", user, pwd);
                drivers.AntiVirus = Reader.InfoReader("AntiVirus");
                ThreadCmd.comando("netsh advfirewall show allprofiles", "Firewall", user, pwd);
                drivers.Firewall = Reader.InfoReader("Firewall");
                ThreadCmd.comando("netsh winhttp show proxy", "Proxy", user, pwd);
                drivers.Proxy = Reader.InfoReader("Proxy");
                timer.Stop();

                #endregion

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
                geralExitTimer += timer.ElapsedMilliseconds / 1000;
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

                #region (Hardware) escrita dos txts e leitura/vinculo ao Model;

                if (GetLocale() == "en-US")
                {
                    ThreadCmd.comando("systeminfo | findstr \"Product ID\"", "Product_ID", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"Total Physical Memory\"", "mRam", user, pwd);
                }
                else
                {
                    ThreadCmd.comando("systeminfo | findstr \"Identificação do produto\"", "Product_ID", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"Memória física total\"", "mRam", user, pwd);
                }

                hardware.ProductID = Reader.InfoReader("Product_ID");
                hardware.mRam = Reader.InfoReader("mRam");

                ThreadCmd.comando("wmic computersystem get manufacturer", "Manufacturer", user, pwd);
                hardware.ManufacturerAndModel = Reader.InfoReader("Manufacturer");
                ThreadCmd.comando("wmic desktopmonitor get Name,MonitorType,MonitorManufacturer", "Displays", user, pwd);
                hardware.Display = Reader.InfoReader("Displays");
                ThreadCmd.comando("wmic path win32_VideoController get name", "GraphicCard", user, pwd);
                hardware.GraphicCard = Reader.InfoReader("GraphicCard");
                ThreadCmd.comando("wmic diskdrive get model, size", "HD", user, pwd);
                hardware.HardDisk = Reader.InfoReader("HD");
                ThreadCmd.comando("wmic baseboard get product", "MotherBoard", user, pwd);
                hardware.MotherBoard = Reader.InfoReader("MotherBoard");
                ThreadCmd.comando("wmic cpu get name", "Processor", user, pwd);
                hardware.Processor = Reader.InfoReader("Processor");

                #endregion

                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
                geralExitTimer += timer.ElapsedMilliseconds / 1000;
            } catch (Exception ex)
            {
                MessageBox.Show("Error creating Hardware relatory" + ex.Message);
            }
            
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            try
            {

                Stopwatch timer = new Stopwatch();
                timer.Start();

                #region (SystemInfo) escrita dos txts e leitura/vinculo ao Model;

                if (GetLocale() == "en-US")
                {
                    ThreadCmd.comando("systeminfo | find \"Domain\"", "Domain", user, pwd);
                    ThreadCmd.comando("ipconfig | find \"IPv4 Address\"", "IP", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"OS Name\"", "OS", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"Original Install Date\"", "InstallDate", user, pwd);
                }
                else
                {
                    ThreadCmd.comando("systeminfo | find \"Domínio\"", "Domain", user, pwd);
                    ThreadCmd.comando("ipconfig | find \"Endereço IPv4\"", "IP", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"Nome do sistema operacional\"", "OS", user, pwd);
                    ThreadCmd.comando("systeminfo | find \"Data de instalação original\"", "InstallDate", user, pwd);
                }

                systemInfo.Domain = Reader.InfoReader("Domain");
                systemInfo.IP = Reader.InfoReader("IP");
                systemInfo.OS = Reader.InfoReader("OS");
                systemInfo.InstallDate = Reader.InfoReader("InstallDate");

                ThreadCmd.comando("hostname", "Hostname", user, pwd);
                systemInfo.Hostname = Reader.InfoReader("Hostname");
                ThreadCmd.comando("whoami", "LastUser", user, pwd);
                systemInfo.LastUserName = Reader.InfoReader("LastUser");
                systemInfo.FirstSync = DateTime.Now;

                #endregion

                timer.Stop();

                individualExitTimer = 0;
                individualExitTimer = timer.ElapsedMilliseconds / 1000;
                geralExitTimer += timer.ElapsedMilliseconds / 1000;
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

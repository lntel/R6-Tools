using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IniParser;
using IniParser.Model;
using Bunifu;

namespace R6RS
{
    public partial class Form1 : Form
    {
        private bool firstTime = true;
        public bool isWritable = false;
        private Ini ini;

        private string[] accounts;
        private string path;
        private string new_path;


        private readonly Dictionary<string, string> Regions = new Dictionary<string, string>
        {
            { "default", "Ping Based" },
            { "eus", "US East" },
            { "cus", "US Central" },
            { "scus", "US South Central" },
            { "wus", "US West" },
            { "sbr", "Brazil South" },
            { "neu", "Europe North" },
            { "weu", "Europe West" },
            { "eas", "Asia East" },
            { "seas", "Asia South East" },
            { "eau", "Australia East" },
            { "wja", "Japan West" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Rainbow Six - Siege";
            new_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            accounts = Directory.GetDirectories(path);

            ini = new Ini(accounts, new_path, this);

            MakeWritable();

            ini.Read();

            TxtHorizontal.Text = ini.data["INPUT"]["MouseYawSensitivity"];
            TxtVertical.Text = ini.data["INPUT"]["MousePitchSensitivity"];
            TxtMultiplier.Text = ini.data["INPUT"]["MouseSensitivityMultiplierUnit"];
            TxtADS.Text = ini.data["INPUT"]["AimDownSightsMouse"];

            int region = 0;

            switch(ini.data["ONLINE"]["DataCenterHint"])
            {
                case "default":
                    region = 0;
                    break;
                case "eus":
                    region = 1;
                    break;
                case "cus":
                    region = 2;
                    break;
                case "scus":
                    region = 3;
                    break;
                case "wus":
                    region = 4;
                    break;
                case "sbr":
                    region = 5;
                    break;
                case "neu":
                    region = 6;
                    break;
                case "weu":
                    region = 7;
                    break;
                case "eas":
                    region = 8;
                    break;
                case "seas":
                    region = 9;
                    break;
                case "eau":
                    region = 10;
                    break;
                case "wja":
                    region = 11;
                    break;
            }

            bunifuDropdown1.selectedIndex = region;

        }

        private void MakeWritable()
        {
            foreach (string account in accounts)
            {
                File.Move(Path.Combine(path, Path.GetFileName(account)) + @"\GameSettings.ini", Path.Combine(new_path, Path.GetFileName(account)));
            }

            isWritable = true;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if(!firstTime)
            {
                if(!isWritable)
                {
                    MakeWritable();
                }

                string key = Regions.FirstOrDefault(x => x.Value == bunifuDropdown1.selectedValue).Key;

                ini.data["ONLINE"]["DataCenterHint"] = key;
                ini.Write();

                LblUpdate.Text = string.Format("Region set to {0}", bunifuDropdown1.selectedValue);
                
            } else
            {
                firstTime = false;
            }
        }
    }

    public class Ini
    {
        public IniData data;

        private FileIniDataParser parser;
        private string[] paths;
        private string mn_path;
        private Form1 main;
        public Ini(string[] files, string path, Form1 frm)
        {
            parser = new FileIniDataParser();
            paths = files;
            mn_path = path;
            main = frm;
        }

        public void Read()
        {
            data = parser.ReadFile(Path.Combine(mn_path, Path.GetFileName(paths[0])));
        }

        public void Write()
        {
            string old = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Rainbow Six - Siege";

            foreach (string path in paths)
            {
                string link = Path.Combine(mn_path, Path.GetFileName(path));
                parser.WriteFile(link, data);

                File.Move(link, Path.Combine(old, Path.GetFileName(link)) + @"\GameSettings.ini");
            }

            main.isWritable = false;
        }
    }
}

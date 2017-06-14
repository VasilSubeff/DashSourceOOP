using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashSourceConfiguration
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
            ConfigManager.UpdateConfiguration(Properties.Settings.Default.fronEndConfigFile, Properties.Settings.Default.frontEndAppName, "backendSettings", settingsFilePathTxtBox.Text);
            emailTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "userSetting");
            passwordTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "passwordSetting");
            emailInputTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "emailInputFolderSetting");
            archiveEmailTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "emailProcessedFolderSetting");
            delimiterTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "Delimiter");
            fileInputTxtBox.Text = ConfigManager.ReadSetting(Properties.Settings.Default.backendSettings, Properties.Settings.Default.backEndAppName, "inputDirectorySetting");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsFilePathTxtBox.Text = Properties.Settings.Default.backendSettings;
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                settingsFilePathTxtBox.Text = file;
            }

            
        }
    }
}


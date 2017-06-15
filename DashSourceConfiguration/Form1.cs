using System;
using System.Diagnostics;
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
            try
            {
                ConfigManager.UpdateConfiguration(Properties.Settings.Default.fronEndConfigFile, Properties.Settings.Default.frontEndAppName, "backendSettings", settingsFilePathTxtBox.Text);
                emailTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "userSetting");
                passwordTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "passwordSetting");
                emailInputTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "emailInputFolderSetting");
                archiveEmailTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "emailProcessedFolderSetting");
                delimiterTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "Delimiter");
                fileInputTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "inputDirectorySetting");
                fileArchiveTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "archiveDirSetting");
                logDirTxtBox.Text = ConfigManager.ReadSetting(settingsFilePathTxtBox.Text, "logPathSetting");
                connStringTxtBox.Text = ConfigManager.ReadConnectionString(Properties.Settings.Default.backendSettings);
                metroPanel1.Visible = true;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Invalid configuration file", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
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

        private void inputBrowseButton_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    fileInputTxtBox.Text = folder.SelectedPath + "\\";
                }
            }
        }

        private void archiveBrowseButton_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    fileArchiveTxtBox.Text = folder.SelectedPath + "\\";
                }
            }
        }

        private void logBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog2.FileName;
                logDirTxtBox.Text = file;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Properties.Settings.Default.backendSettings;
                emailTxtBox.Text = ConfigManager.ReadSetting(filePath, "userSetting");
                passwordTxtBox.Text = ConfigManager.ReadSetting(filePath, "passwordSetting");
                emailInputTxtBox.Text = ConfigManager.ReadSetting(filePath, "emailInputFolderSetting");
                archiveEmailTxtBox.Text = ConfigManager.ReadSetting(filePath, "emailProcessedFolderSetting");
                delimiterTxtBox.Text = ConfigManager.ReadSetting(filePath, "Delimiter");
                fileInputTxtBox.Text = ConfigManager.ReadSetting(filePath, "inputDirectorySetting");
                fileArchiveTxtBox.Text = ConfigManager.ReadSetting(filePath, "archiveDirSetting");
                logDirTxtBox.Text = ConfigManager.ReadSetting(filePath, "logPathSetting");
                connStringTxtBox.Text = ConfigManager.ReadConnectionString(Properties.Settings.Default.backendSettings);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Cannot reset settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string configPath = Properties.Settings.Default.backendSettings;
                string exePath = configPath.Substring(0, configPath.Length - 7);
                Process.Start(exePath);
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Cannot start DashSource.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string backendSettings = Properties.Settings.Default.backendSettings;
                string backendAppname = Properties.Settings.Default.backEndAppName;

                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "userSetting", emailTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "passwordSetting", passwordTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "emailInputFolderSetting", emailInputTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "emailProcessedFolderSetting", archiveEmailTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "Delimiter", delimiterTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "inputDirectorySetting", fileInputTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "archiveDirSetting", fileArchiveTxtBox.Text);
                ConfigManager.UpdateConfiguration(backendSettings, backendAppname, "logPathSetting", logDirTxtBox.Text);
                ConfigManager.UpdateConnectionString(backendSettings, connStringTxtBox.Text);

                MetroFramework.MetroMessageBox.Show(this, "Settings saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Cannot start DashSource.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


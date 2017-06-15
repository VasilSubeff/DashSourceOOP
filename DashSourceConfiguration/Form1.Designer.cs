namespace DashSourceConfiguration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new MetroFramework.Controls.MetroButton();
            this.settingsFilePathTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.settingsFilePathLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.browseButton = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.logBrowseButton = new MetroFramework.Controls.MetroButton();
            this.archiveBrowseButton = new MetroFramework.Controls.MetroButton();
            this.inputBrowseButton = new MetroFramework.Controls.MetroButton();
            this.connStringTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.logDirTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.fileArchiveTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fileInputTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.delimiterTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.archiveEmailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.emailInputTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.executeButton = new MetroFramework.Controls.MetroButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton.Location = new System.Drawing.Point(128, 200);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(92, 28);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Load";
            this.OpenButton.UseCustomBackColor = true;
            this.OpenButton.UseSelectable = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // settingsFilePathTxtBox
            // 
            // 
            // 
            // 
            this.settingsFilePathTxtBox.CustomButton.Image = null;
            this.settingsFilePathTxtBox.CustomButton.Location = new System.Drawing.Point(466, 2);
            this.settingsFilePathTxtBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsFilePathTxtBox.CustomButton.Name = "";
            this.settingsFilePathTxtBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.settingsFilePathTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.settingsFilePathTxtBox.CustomButton.TabIndex = 1;
            this.settingsFilePathTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.settingsFilePathTxtBox.CustomButton.UseSelectable = true;
            this.settingsFilePathTxtBox.CustomButton.Visible = false;
            this.settingsFilePathTxtBox.Lines = new string[] {
        "metroTextBox2"};
            this.settingsFilePathTxtBox.Location = new System.Drawing.Point(28, 165);
            this.settingsFilePathTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsFilePathTxtBox.MaxLength = 32767;
            this.settingsFilePathTxtBox.Name = "settingsFilePathTxtBox";
            this.settingsFilePathTxtBox.PasswordChar = '\0';
            this.settingsFilePathTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.settingsFilePathTxtBox.SelectedText = "";
            this.settingsFilePathTxtBox.SelectionLength = 0;
            this.settingsFilePathTxtBox.SelectionStart = 0;
            this.settingsFilePathTxtBox.ShortcutsEnabled = true;
            this.settingsFilePathTxtBox.Size = new System.Drawing.Size(492, 28);
            this.settingsFilePathTxtBox.TabIndex = 2;
            this.settingsFilePathTxtBox.Text = "metroTextBox2";
            this.settingsFilePathTxtBox.UseSelectable = true;
            this.settingsFilePathTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.settingsFilePathTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // settingsFilePathLabel
            // 
            this.settingsFilePathLabel.AutoScroll = true;
            this.settingsFilePathLabel.AutoScrollMinSize = new System.Drawing.Size(170, 26);
            this.settingsFilePathLabel.AutoSize = false;
            this.settingsFilePathLabel.BackColor = System.Drawing.SystemColors.Window;
            this.settingsFilePathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsFilePathLabel.Location = new System.Drawing.Point(26, 130);
            this.settingsFilePathLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsFilePathLabel.Name = "settingsFilePathLabel";
            this.settingsFilePathLabel.Size = new System.Drawing.Size(432, 27);
            this.settingsFilePathLabel.TabIndex = 1;
            this.settingsFilePathLabel.Text = "Browse configuration file";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Transparent;
            this.browseButton.Location = new System.Drawing.Point(28, 200);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(94, 28);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseCustomBackColor = true;
            this.browseButton.UseSelectable = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.executeButton);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.saveButton);
            this.metroPanel1.Controls.Add(this.closeButton);
            this.metroPanel1.Controls.Add(this.resetButton);
            this.metroPanel1.Controls.Add(this.logBrowseButton);
            this.metroPanel1.Controls.Add(this.archiveBrowseButton);
            this.metroPanel1.Controls.Add(this.inputBrowseButton);
            this.metroPanel1.Controls.Add(this.connStringTxtBox);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.logDirTxtBox);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.fileArchiveTxtBox);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.fileInputTxtBox);
            this.metroPanel1.Controls.Add(this.delimiterTxtBox);
            this.metroPanel1.Controls.Add(this.archiveEmailTxtBox);
            this.metroPanel1.Controls.Add(this.emailInputTxtBox);
            this.metroPanel1.Controls.Add(this.passwordTxtBox);
            this.metroPanel1.Controls.Add(this.emailTxtBox);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(741, 433);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(33, 407);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 32;
            this.resetButton.Text = "Reset";
            this.resetButton.UseCustomBackColor = true;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // logBrowseButton
            // 
            this.logBrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.logBrowseButton.Location = new System.Drawing.Point(674, 150);
            this.logBrowseButton.Name = "logBrowseButton";
            this.logBrowseButton.Size = new System.Drawing.Size(24, 23);
            this.logBrowseButton.TabIndex = 31;
            this.logBrowseButton.Text = "...";
            this.logBrowseButton.UseCustomBackColor = true;
            this.logBrowseButton.UseSelectable = true;
            this.logBrowseButton.Click += new System.EventHandler(this.logBrowseButton_Click);
            // 
            // archiveBrowseButton
            // 
            this.archiveBrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.archiveBrowseButton.Location = new System.Drawing.Point(674, 119);
            this.archiveBrowseButton.Name = "archiveBrowseButton";
            this.archiveBrowseButton.Size = new System.Drawing.Size(24, 23);
            this.archiveBrowseButton.TabIndex = 30;
            this.archiveBrowseButton.Text = "...";
            this.archiveBrowseButton.UseCustomBackColor = true;
            this.archiveBrowseButton.UseSelectable = true;
            this.archiveBrowseButton.Click += new System.EventHandler(this.archiveBrowseButton_Click);
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.BackColor = System.Drawing.Color.White;
            this.inputBrowseButton.Location = new System.Drawing.Point(674, 85);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(24, 23);
            this.inputBrowseButton.TabIndex = 29;
            this.inputBrowseButton.Text = "...";
            this.inputBrowseButton.UseCustomBackColor = true;
            this.inputBrowseButton.UseSelectable = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // connStringTxtBox
            // 
            // 
            // 
            // 
            this.connStringTxtBox.CustomButton.Image = null;
            this.connStringTxtBox.CustomButton.Location = new System.Drawing.Point(459, 1);
            this.connStringTxtBox.CustomButton.Name = "";
            this.connStringTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.connStringTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.connStringTxtBox.CustomButton.TabIndex = 1;
            this.connStringTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connStringTxtBox.CustomButton.UseSelectable = true;
            this.connStringTxtBox.CustomButton.Visible = false;
            this.connStringTxtBox.Lines = new string[] {
        "connection string"};
            this.connStringTxtBox.Location = new System.Drawing.Point(186, 225);
            this.connStringTxtBox.MaxLength = 32767;
            this.connStringTxtBox.Name = "connStringTxtBox";
            this.connStringTxtBox.PasswordChar = '\0';
            this.connStringTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.connStringTxtBox.SelectedText = "";
            this.connStringTxtBox.SelectionLength = 0;
            this.connStringTxtBox.SelectionStart = 0;
            this.connStringTxtBox.ShortcutsEnabled = true;
            this.connStringTxtBox.Size = new System.Drawing.Size(481, 23);
            this.connStringTxtBox.TabIndex = 28;
            this.connStringTxtBox.Text = "connection string";
            this.connStringTxtBox.UseSelectable = true;
            this.connStringTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.connStringTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(33, 229);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(113, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Connection String";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(33, 197);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(112, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Database Settings";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(370, 21);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(78, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "File Settings";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(33, 21);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(90, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Email Settings";
            // 
            // logDirTxtBox
            // 
            // 
            // 
            // 
            this.logDirTxtBox.CustomButton.Image = null;
            this.logDirTxtBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.logDirTxtBox.CustomButton.Name = "";
            this.logDirTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.logDirTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logDirTxtBox.CustomButton.TabIndex = 1;
            this.logDirTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logDirTxtBox.CustomButton.UseSelectable = true;
            this.logDirTxtBox.CustomButton.Visible = false;
            this.logDirTxtBox.Lines = new string[] {
        "log directory"};
            this.logDirTxtBox.Location = new System.Drawing.Point(512, 151);
            this.logDirTxtBox.MaxLength = 32767;
            this.logDirTxtBox.Name = "logDirTxtBox";
            this.logDirTxtBox.PasswordChar = '\0';
            this.logDirTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logDirTxtBox.SelectedText = "";
            this.logDirTxtBox.SelectionLength = 0;
            this.logDirTxtBox.SelectionStart = 0;
            this.logDirTxtBox.ShortcutsEnabled = true;
            this.logDirTxtBox.Size = new System.Drawing.Size(155, 23);
            this.logDirTxtBox.TabIndex = 23;
            this.logDirTxtBox.Text = "log directory";
            this.logDirTxtBox.UseSelectable = true;
            this.logDirTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logDirTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(370, 158);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Log Filepath";
            // 
            // fileArchiveTxtBox
            // 
            // 
            // 
            // 
            this.fileArchiveTxtBox.CustomButton.Image = null;
            this.fileArchiveTxtBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.fileArchiveTxtBox.CustomButton.Name = "";
            this.fileArchiveTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fileArchiveTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fileArchiveTxtBox.CustomButton.TabIndex = 1;
            this.fileArchiveTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fileArchiveTxtBox.CustomButton.UseSelectable = true;
            this.fileArchiveTxtBox.CustomButton.Visible = false;
            this.fileArchiveTxtBox.Lines = new string[] {
        "file Archive"};
            this.fileArchiveTxtBox.Location = new System.Drawing.Point(512, 119);
            this.fileArchiveTxtBox.MaxLength = 32767;
            this.fileArchiveTxtBox.Name = "fileArchiveTxtBox";
            this.fileArchiveTxtBox.PasswordChar = '\0';
            this.fileArchiveTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fileArchiveTxtBox.SelectedText = "";
            this.fileArchiveTxtBox.SelectionLength = 0;
            this.fileArchiveTxtBox.SelectionStart = 0;
            this.fileArchiveTxtBox.ShortcutsEnabled = true;
            this.fileArchiveTxtBox.Size = new System.Drawing.Size(155, 23);
            this.fileArchiveTxtBox.TabIndex = 21;
            this.fileArchiveTxtBox.Text = "file Archive";
            this.fileArchiveTxtBox.UseSelectable = true;
            this.fileArchiveTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fileArchiveTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(33, 56);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Email address";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(33, 92);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Password";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 126);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(132, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Email Input Directory";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(146, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Email Archive Directory";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(370, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Delimiter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(370, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "File Input Directory";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(370, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "File Archive Directory";
            // 
            // fileInputTxtBox
            // 
            // 
            // 
            // 
            this.fileInputTxtBox.CustomButton.Image = null;
            this.fileInputTxtBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.fileInputTxtBox.CustomButton.Name = "";
            this.fileInputTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fileInputTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fileInputTxtBox.CustomButton.TabIndex = 1;
            this.fileInputTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fileInputTxtBox.CustomButton.UseSelectable = true;
            this.fileInputTxtBox.CustomButton.Visible = false;
            this.fileInputTxtBox.Lines = new string[] {
        "input dir"};
            this.fileInputTxtBox.Location = new System.Drawing.Point(512, 85);
            this.fileInputTxtBox.MaxLength = 32767;
            this.fileInputTxtBox.Name = "fileInputTxtBox";
            this.fileInputTxtBox.PasswordChar = '\0';
            this.fileInputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fileInputTxtBox.SelectedText = "";
            this.fileInputTxtBox.SelectionLength = 0;
            this.fileInputTxtBox.SelectionStart = 0;
            this.fileInputTxtBox.ShortcutsEnabled = true;
            this.fileInputTxtBox.Size = new System.Drawing.Size(155, 23);
            this.fileInputTxtBox.TabIndex = 13;
            this.fileInputTxtBox.Text = "input dir";
            this.fileInputTxtBox.UseSelectable = true;
            this.fileInputTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fileInputTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // delimiterTxtBox
            // 
            // 
            // 
            // 
            this.delimiterTxtBox.CustomButton.Image = null;
            this.delimiterTxtBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.delimiterTxtBox.CustomButton.Name = "";
            this.delimiterTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.delimiterTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.delimiterTxtBox.CustomButton.TabIndex = 1;
            this.delimiterTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delimiterTxtBox.CustomButton.UseSelectable = true;
            this.delimiterTxtBox.CustomButton.Visible = false;
            this.delimiterTxtBox.Lines = new string[] {
        "delimiter"};
            this.delimiterTxtBox.Location = new System.Drawing.Point(512, 53);
            this.delimiterTxtBox.MaxLength = 32767;
            this.delimiterTxtBox.Name = "delimiterTxtBox";
            this.delimiterTxtBox.PasswordChar = '\0';
            this.delimiterTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delimiterTxtBox.SelectedText = "";
            this.delimiterTxtBox.SelectionLength = 0;
            this.delimiterTxtBox.SelectionStart = 0;
            this.delimiterTxtBox.ShortcutsEnabled = true;
            this.delimiterTxtBox.Size = new System.Drawing.Size(155, 23);
            this.delimiterTxtBox.TabIndex = 11;
            this.delimiterTxtBox.Text = "delimiter";
            this.delimiterTxtBox.UseSelectable = true;
            this.delimiterTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.delimiterTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // archiveEmailTxtBox
            // 
            // 
            // 
            // 
            this.archiveEmailTxtBox.CustomButton.Image = null;
            this.archiveEmailTxtBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.archiveEmailTxtBox.CustomButton.Name = "";
            this.archiveEmailTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.archiveEmailTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.archiveEmailTxtBox.CustomButton.TabIndex = 1;
            this.archiveEmailTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.archiveEmailTxtBox.CustomButton.UseSelectable = true;
            this.archiveEmailTxtBox.CustomButton.Visible = false;
            this.archiveEmailTxtBox.Lines = new string[] {
        "archive Email"};
            this.archiveEmailTxtBox.Location = new System.Drawing.Point(186, 158);
            this.archiveEmailTxtBox.MaxLength = 32767;
            this.archiveEmailTxtBox.Name = "archiveEmailTxtBox";
            this.archiveEmailTxtBox.PasswordChar = '\0';
            this.archiveEmailTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.archiveEmailTxtBox.SelectedText = "";
            this.archiveEmailTxtBox.SelectionLength = 0;
            this.archiveEmailTxtBox.SelectionStart = 0;
            this.archiveEmailTxtBox.ShortcutsEnabled = true;
            this.archiveEmailTxtBox.Size = new System.Drawing.Size(144, 23);
            this.archiveEmailTxtBox.TabIndex = 9;
            this.archiveEmailTxtBox.Text = "archive Email";
            this.archiveEmailTxtBox.UseSelectable = true;
            this.archiveEmailTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.archiveEmailTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailInputTxtBox
            // 
            // 
            // 
            // 
            this.emailInputTxtBox.CustomButton.Image = null;
            this.emailInputTxtBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.emailInputTxtBox.CustomButton.Name = "";
            this.emailInputTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailInputTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailInputTxtBox.CustomButton.TabIndex = 1;
            this.emailInputTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailInputTxtBox.CustomButton.UseSelectable = true;
            this.emailInputTxtBox.CustomButton.Visible = false;
            this.emailInputTxtBox.Lines = new string[] {
        "input Email"};
            this.emailInputTxtBox.Location = new System.Drawing.Point(186, 123);
            this.emailInputTxtBox.MaxLength = 32767;
            this.emailInputTxtBox.Name = "emailInputTxtBox";
            this.emailInputTxtBox.PasswordChar = '\0';
            this.emailInputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailInputTxtBox.SelectedText = "";
            this.emailInputTxtBox.SelectionLength = 0;
            this.emailInputTxtBox.SelectionStart = 0;
            this.emailInputTxtBox.ShortcutsEnabled = true;
            this.emailInputTxtBox.Size = new System.Drawing.Size(144, 23);
            this.emailInputTxtBox.TabIndex = 7;
            this.emailInputTxtBox.Text = "input Email";
            this.emailInputTxtBox.UseSelectable = true;
            this.emailInputTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailInputTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTxtBox
            // 
            // 
            // 
            // 
            this.passwordTxtBox.CustomButton.Image = null;
            this.passwordTxtBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.passwordTxtBox.CustomButton.Name = "";
            this.passwordTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTxtBox.CustomButton.TabIndex = 1;
            this.passwordTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTxtBox.CustomButton.UseSelectable = true;
            this.passwordTxtBox.CustomButton.Visible = false;
            this.passwordTxtBox.Lines = new string[] {
        "password"};
            this.passwordTxtBox.Location = new System.Drawing.Point(186, 93);
            this.passwordTxtBox.MaxLength = 32767;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.SelectionLength = 0;
            this.passwordTxtBox.SelectionStart = 0;
            this.passwordTxtBox.ShortcutsEnabled = true;
            this.passwordTxtBox.Size = new System.Drawing.Size(144, 23);
            this.passwordTxtBox.TabIndex = 5;
            this.passwordTxtBox.Text = "password";
            this.passwordTxtBox.UseSelectable = true;
            this.passwordTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTxtBox
            // 
            // 
            // 
            // 
            this.emailTxtBox.CustomButton.Image = null;
            this.emailTxtBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.emailTxtBox.CustomButton.Name = "";
            this.emailTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxtBox.CustomButton.TabIndex = 1;
            this.emailTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxtBox.CustomButton.UseSelectable = true;
            this.emailTxtBox.CustomButton.Visible = false;
            this.emailTxtBox.Lines = new string[] {
        "Email"};
            this.emailTxtBox.Location = new System.Drawing.Point(186, 56);
            this.emailTxtBox.MaxLength = 32767;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '\0';
            this.emailTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxtBox.SelectedText = "";
            this.emailTxtBox.SelectionLength = 0;
            this.emailTxtBox.SelectionStart = 0;
            this.emailTxtBox.ShortcutsEnabled = true;
            this.emailTxtBox.Size = new System.Drawing.Size(144, 23);
            this.emailTxtBox.TabIndex = 3;
            this.emailTxtBox.Text = "Email";
            this.emailTxtBox.UseSelectable = true;
            this.emailTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(622, 407);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 33;
            this.closeButton.Text = "Close";
            this.closeButton.UseCustomBackColor = true;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(541, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 34;
            this.saveButton.Text = "Save";
            this.saveButton.UseCustomBackColor = true;
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(33, 271);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(159, 19);
            this.metroLabel13.TabIndex = 35;
            this.metroLabel13.Text = "Run DashSource Manually";
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.White;
            this.executeButton.Location = new System.Drawing.Point(33, 303);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 36;
            this.executeButton.Text = "Execute";
            this.executeButton.UseCustomBackColor = true;
            this.executeButton.UseSelectable = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 532);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.settingsFilePathLabel);
            this.Controls.Add(this.settingsFilePathTxtBox);
            this.Controls.Add(this.OpenButton);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Text = "DashSource Configuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton OpenButton;
        private MetroFramework.Controls.MetroTextBox settingsFilePathTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel settingsFilePathLabel;
        private MetroFramework.Controls.MetroButton browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox emailTxtBox;
        private MetroFramework.Controls.MetroTextBox passwordTxtBox;
        private MetroFramework.Controls.MetroTextBox emailInputTxtBox;
        private MetroFramework.Controls.MetroTextBox archiveEmailTxtBox;
        private MetroFramework.Controls.MetroTextBox delimiterTxtBox;
        private MetroFramework.Controls.MetroTextBox fileInputTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox fileArchiveTxtBox;
        private MetroFramework.Controls.MetroTextBox logDirTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox connStringTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton inputBrowseButton;
        private MetroFramework.Controls.MetroButton archiveBrowseButton;
        private MetroFramework.Controls.MetroButton logBrowseButton;
        private MetroFramework.Controls.MetroButton resetButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroButton executeButton;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}


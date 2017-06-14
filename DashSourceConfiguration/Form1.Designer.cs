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
            this.emailLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.emailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.passwordTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.emailInputTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.archiveEmailTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.delimiterTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.fileInputTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(128, 200);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(92, 28);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Load";
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
            this.browseButton.Location = new System.Drawing.Point(28, 200);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(94, 28);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseSelectable = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.fileInputTxtBox);
            this.metroPanel1.Controls.Add(this.htmlLabel4);
            this.metroPanel1.Controls.Add(this.delimiterTxtBox);
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.archiveEmailTxtBox);
            this.metroPanel1.Controls.Add(this.htmlLabel2);
            this.metroPanel1.Controls.Add(this.emailInputTxtBox);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.passwordTxtBox);
            this.metroPanel1.Controls.Add(this.passwordLabel);
            this.metroPanel1.Controls.Add(this.emailTxtBox);
            this.metroPanel1.Controls.Add(this.emailLabel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(765, 433);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoScroll = true;
            this.emailLabel.AutoScrollMinSize = new System.Drawing.Size(84, 24);
            this.emailLabel.AutoSize = false;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Location = new System.Drawing.Point(32, 24);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(93, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email address";
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
            this.emailTxtBox.Location = new System.Drawing.Point(185, 24);
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
            // passwordLabel
            // 
            this.passwordLabel.AutoScroll = true;
            this.passwordLabel.AutoScrollMinSize = new System.Drawing.Size(61, 24);
            this.passwordLabel.AutoSize = false;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passwordLabel.Location = new System.Drawing.Point(32, 56);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 28);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
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
            this.passwordTxtBox.Location = new System.Drawing.Point(185, 61);
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
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(122, 24);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(32, 91);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(126, 29);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "Email Input Directory";
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
            this.emailInputTxtBox.Location = new System.Drawing.Point(185, 91);
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
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(135, 24);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(32, 126);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(136, 28);
            this.htmlLabel2.TabIndex = 8;
            this.htmlLabel2.Text = "Email Archive Directory";
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
            this.archiveEmailTxtBox.Location = new System.Drawing.Point(185, 126);
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
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(55, 24);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(359, 24);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(99, 25);
            this.htmlLabel3.TabIndex = 10;
            this.htmlLabel3.Text = "Delimiter";
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
            this.delimiterTxtBox.Location = new System.Drawing.Point(501, 24);
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
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(110, 24);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(359, 60);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(138, 24);
            this.htmlLabel4.TabIndex = 12;
            this.htmlLabel4.Text = "File Input Directory";
            // 
            // fileInputTxtBox
            // 
            // 
            // 
            // 
            this.fileInputTxtBox.CustomButton.Image = null;
            this.fileInputTxtBox.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.fileInputTxtBox.CustomButton.Name = "";
            this.fileInputTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fileInputTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fileInputTxtBox.CustomButton.TabIndex = 1;
            this.fileInputTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fileInputTxtBox.CustomButton.UseSelectable = true;
            this.fileInputTxtBox.CustomButton.Visible = false;
            this.fileInputTxtBox.Lines = new string[] {
        "input dir"};
            this.fileInputTxtBox.Location = new System.Drawing.Point(501, 60);
            this.fileInputTxtBox.MaxLength = 32767;
            this.fileInputTxtBox.Name = "fileInputTxtBox";
            this.fileInputTxtBox.PasswordChar = '\0';
            this.fileInputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fileInputTxtBox.SelectedText = "";
            this.fileInputTxtBox.SelectionLength = 0;
            this.fileInputTxtBox.SelectionStart = 0;
            this.fileInputTxtBox.ShortcutsEnabled = true;
            this.fileInputTxtBox.Size = new System.Drawing.Size(153, 23);
            this.fileInputTxtBox.TabIndex = 13;
            this.fileInputTxtBox.Text = "input dir";
            this.fileInputTxtBox.UseSelectable = true;
            this.fileInputTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fileInputTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 532);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton OpenButton;
        private MetroFramework.Controls.MetroTextBox settingsFilePathTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel settingsFilePathLabel;
        private MetroFramework.Controls.MetroButton browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Drawing.Html.HtmlLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTxtBox;
        private MetroFramework.Controls.MetroTextBox passwordTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox emailInputTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox archiveEmailTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox delimiterTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox fileInputTxtBox;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
    }
}


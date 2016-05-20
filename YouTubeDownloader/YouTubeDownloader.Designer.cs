namespace YouTubeDownloader
{
    partial class YouTubeDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeDownloader));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeURLLabel = new System.Windows.Forms.Label();
            this.youTubeURLTextBox = new System.Windows.Forms.TextBox();
            this.getVideosButton = new System.Windows.Forms.Button();
            this.youTubeWebBrowser = new System.Windows.Forms.WebBrowser();
            this.videoQualityLabel = new System.Windows.Forms.Label();
            this.videoQualityComboBox = new System.Windows.Forms.ComboBox();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.saveLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.saveLocationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveLocationSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1166, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // youTubeURLLabel
            // 
            this.youTubeURLLabel.AutoSize = true;
            this.youTubeURLLabel.Location = new System.Drawing.Point(82, 37);
            this.youTubeURLLabel.Name = "youTubeURLLabel";
            this.youTubeURLLabel.Size = new System.Drawing.Size(79, 13);
            this.youTubeURLLabel.TabIndex = 1;
            this.youTubeURLLabel.Text = "YouTube URL:";
            // 
            // youTubeURLTextBox
            // 
            this.youTubeURLTextBox.Location = new System.Drawing.Point(187, 39);
            this.youTubeURLTextBox.Name = "youTubeURLTextBox";
            this.youTubeURLTextBox.Size = new System.Drawing.Size(707, 20);
            this.youTubeURLTextBox.TabIndex = 0;
            // 
            // getVideosButton
            // 
            this.getVideosButton.Location = new System.Drawing.Point(918, 37);
            this.getVideosButton.Name = "getVideosButton";
            this.getVideosButton.Size = new System.Drawing.Size(75, 23);
            this.getVideosButton.TabIndex = 1;
            this.getVideosButton.Text = "&Get Videos";
            this.getVideosButton.UseVisualStyleBackColor = true;
            this.getVideosButton.Click += new System.EventHandler(this.getVideosButton_Click);
            // 
            // youTubeWebBrowser
            // 
            this.youTubeWebBrowser.Location = new System.Drawing.Point(68, 66);
            this.youTubeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.youTubeWebBrowser.Name = "youTubeWebBrowser";
            this.youTubeWebBrowser.Size = new System.Drawing.Size(1036, 449);
            this.youTubeWebBrowser.TabIndex = 2;
            this.youTubeWebBrowser.TabStop = false;
            this.youTubeWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.youTubeWebBrowser_Navigated);
            // 
            // videoQualityLabel
            // 
            this.videoQualityLabel.AutoSize = true;
            this.videoQualityLabel.Location = new System.Drawing.Point(82, 554);
            this.videoQualityLabel.Name = "videoQualityLabel";
            this.videoQualityLabel.Size = new System.Drawing.Size(72, 13);
            this.videoQualityLabel.TabIndex = 5;
            this.videoQualityLabel.Text = "Video Quality:";
            // 
            // videoQualityComboBox
            // 
            this.videoQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoQualityComboBox.FormattingEnabled = true;
            this.videoQualityComboBox.Location = new System.Drawing.Point(187, 551);
            this.videoQualityComboBox.Name = "videoQualityComboBox";
            this.videoQualityComboBox.Size = new System.Drawing.Size(220, 21);
            this.videoQualityComboBox.TabIndex = 3;
            this.videoQualityComboBox.SelectedIndexChanged += new System.EventHandler(this.videoQualityComboBox_SelectedIndexChanged);
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(82, 617);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(79, 13);
            this.saveLocationLabel.TabIndex = 7;
            this.saveLocationLabel.Text = "Save Location:";
            // 
            // saveLocationTextBox
            // 
            this.saveLocationTextBox.Location = new System.Drawing.Point(187, 614);
            this.saveLocationTextBox.Name = "saveLocationTextBox";
            this.saveLocationTextBox.Size = new System.Drawing.Size(579, 20);
            this.saveLocationTextBox.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(772, 612);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(800, 537);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 30);
            this.statusLabel.TabIndex = 10;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.Location = new System.Drawing.Point(972, 594);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(168, 52);
            this.downloadButton.TabIndex = 6;
            this.downloadButton.Text = "&Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(1022, 37);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(55, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // YouTubeDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(1166, 669);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.saveLocationTextBox);
            this.Controls.Add(this.saveLocationLabel);
            this.Controls.Add(this.videoQualityComboBox);
            this.Controls.Add(this.videoQualityLabel);
            this.Controls.Add(this.youTubeWebBrowser);
            this.Controls.Add(this.getVideosButton);
            this.Controls.Add(this.youTubeURLTextBox);
            this.Controls.Add(this.youTubeURLLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "YouTubeDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label youTubeURLLabel;
        private System.Windows.Forms.TextBox youTubeURLTextBox;
        private System.Windows.Forms.Button getVideosButton;
        private System.Windows.Forms.WebBrowser youTubeWebBrowser;
        private System.Windows.Forms.Label videoQualityLabel;
        private System.Windows.Forms.ComboBox videoQualityComboBox;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.TextBox saveLocationTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.FolderBrowserDialog saveLocationFolderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveLocationSaveFileDialog;
        private System.Windows.Forms.Button clearButton;
    }
}


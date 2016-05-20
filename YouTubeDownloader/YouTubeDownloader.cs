using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;using System.Text.RegularExpressions;using System.IO;
namespace YouTubeDownloader
{

    /// <summary>
    /// Applications that downloads YouTube videos using "YouTubeDownloader" library.
    /// </summary>
    public partial class YouTubeDownloader : Form
    {
        //Global variable
        public VideoInfo[] videoInfos;

        public YouTubeDownloader()
        {
            InitializeComponent();
            //Intialize Web Browser Component to YouTube Website
            youTubeWebBrowser.Navigate("https://www.youtube.com/");
        }

        /// <summary>
        /// Event Handler for a change in the URL of the Web Browser Component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void youTubeWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //Assign new URL to URL TextBox
            youTubeURLTextBox.Text = youTubeWebBrowser.Url.ToString();
        }
 
        /// <summary>
        /// Get all the videos availables for the selection of the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getVideosButton_Click(object sender, EventArgs e)
        {
            
            //Show message to user to wait while retrieving data
            statusLabel.ForeColor = System.Drawing.Color.Red;
            statusLabel.Text = "Retrieving video options... \nPlease wait.";
            this.Refresh();
            try
            {
                //Clear ComboBox
                videoQualityComboBox.Items.Clear();
                //Clear Array of videos 
                if (videoInfos != null)
                {
                    Array.Clear(videoInfos, 0, videoInfos.Length);
                }
                //Change cursor to wait cursor
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                // Get all available video formats
                videoInfos = DownloadUrlResolver.GetDownloadUrls(youTubeURLTextBox.Text).ToArray();
                //Loop through array of videos
                foreach (VideoInfo currentVideo in videoInfos)
                {
                    //Add video options to Combo Box
                    videoQualityComboBox.Items.Add("Type: " + currentVideo.VideoType.ToString() + " Resolution: " + currentVideo.Resolution.ToString());
                }
                //Show message to user to perform action
                statusLabel.ForeColor = System.Drawing.Color.Green;
                statusLabel.Text = "Select Video Quality.";
                //Change cursor back
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            }
            catch(ArgumentException)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                statusLabel.Text = String.Empty;
                MessageBox.Show("Please provide a valid YouTube URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
            catch (Exception)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                statusLabel.Text = String.Empty;
                MessageBox.Show("There was a problem retrieving the video options.", "Could Not Retrieve Video Options", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prompt saveFileDialog to select the location to save the vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Save the selected video
                VideoInfo video = videoInfos[videoQualityComboBox.SelectedIndex];
                //Using FolderBrowserDialog
                //saveLocationFolderBrowserDialog.ShowDialog();
                //saveLocationTextBox.Text = saveLocationFolderBrowserDialog.SelectedPath + "\\" + video.Title + video.VideoExtension;

                //Using SaveFileDialog
                DialogResult drDialogResult; //store the dialog result
                saveLocationSaveFileDialog.Filter = video.VideoExtension + " Files|*" + video.VideoExtension;
                saveLocationSaveFileDialog.FileName = video.Title + video.VideoExtension;
                saveLocationSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                saveLocationSaveFileDialog.OverwritePrompt = true;
                drDialogResult = saveLocationSaveFileDialog.ShowDialog();
                if (drDialogResult != DialogResult.Cancel)
                {
                    //Show in text box selected path and default video name
                    saveLocationTextBox.Text = saveLocationSaveFileDialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You need to select a video first.", "Select Video", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Download the video and perform verification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadButton_Click(object sender, EventArgs e)
        {
            try {
                //Temporary variable to store the filename
                string fileName = System.IO.Path.GetFileName(saveLocationTextBox.Text);
                //Loop and replace invalid characters in filename
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(c, '_');
                }
                //Check if the file already exists in the selected directory
                if (File.Exists(System.IO.Path.GetDirectoryName(saveLocationTextBox.Text) + "\\" + fileName))
                {
                    //Message to override file 
                    DialogResult dialogResult = MessageBox.Show("A file already exists with that name, would you like to overwrite the file?", "File Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Change cursor to wait cursor
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                        //Show message to user that is downloading
                        statusLabel.ForeColor = System.Drawing.Color.Red;
                        statusLabel.Text = "Downloading Video...\nPlease wait";
                        this.Refresh();
                        //Select the video user selected
                        VideoInfo video = videoInfos[videoQualityComboBox.SelectedIndex];
                        // Decipher the video if it has a decrypted signature
                        if (video.RequiresDecryption)
                            DownloadUrlResolver.DecryptDownloadUrl(video);

                        // Initiate a new VideoDownloader object, passing the VideoInfo object and save path
                        VideoDownloader videoDownloader = new VideoDownloader(video, System.IO.Path.GetDirectoryName(saveLocationTextBox.Text) + "\\" + fileName);
                        // Execute the video downloader
                        videoDownloader.Execute();
                        //Show message download completed
                        statusLabel.ForeColor = System.Drawing.Color.Green;
                        statusLabel.Text = " Download Completed!";
                        //Change cursor back
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                        //Clear ComboBox
                        videoQualityComboBox.Items.Clear();
                        //Clear Array of videos 
                        if (videoInfos != null)
                        {
                            Array.Clear(videoInfos, 0, videoInfos.Length);
                        }
                        //Clear save location
                        saveLocationTextBox.Text = String.Empty;
                    }
                }
                else
                {
                    //Change cursor to wait cursor
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                    //Show message to user that is downloading
                    statusLabel.ForeColor = System.Drawing.Color.Red;
                    statusLabel.Text = "Downloading Video...\nPlease wait";
                    this.Refresh();
                    //Select the video user selected
                    VideoInfo video = videoInfos[videoQualityComboBox.SelectedIndex];
                    // Decipher the video if it has a decrypted signature
                    if (video.RequiresDecryption)
                        DownloadUrlResolver.DecryptDownloadUrl(video);

                    // Initiate a new VideoDownloader object, passing the VideoInfo object and save path
                    VideoDownloader videoDownloader = new VideoDownloader(video, System.IO.Path.GetDirectoryName(saveLocationTextBox.Text) + "\\" + fileName);
                    // Execute the video downloader
                    videoDownloader.Execute();
                    //Show message download completed
                    statusLabel.ForeColor = System.Drawing.Color.Green;
                    statusLabel.Text = " Download Completed!";
                    //Change cursor back
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                    MessageBox.Show("Video downloaded successfully", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear ComboBox
                    videoQualityComboBox.Items.Clear();
                    //Clear Array of videos 
                    if (videoInfos != null)
                    {
                        Array.Clear(videoInfos, 0, videoInfos.Length);
                    }
                    //Clear save location
                    saveLocationTextBox.Text = String.Empty;
                }
            }
            catch (ArgumentException)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                statusLabel.Text = String.Empty;
                MessageBox.Show("Please provide a valid path to save the vide. Do not include special characters in filename", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                statusLabel.Text = String.Empty;
                MessageBox.Show("Therer was a problem, your video couldn't be downloaded. Please try again", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        //Method to display an about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }
        //Method to modify exit tool strip menu option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method to clear components
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear ComboBox
            videoQualityComboBox.Items.Clear();
            //Clear Array of videos 
            if (videoInfos != null)
            {
                Array.Clear(videoInfos, 0, videoInfos.Length);
            }
            //Clear save location
            saveLocationTextBox.Text = String.Empty;
            //Clear status labe
            statusLabel.Text = String.Empty;
        }
        //Set up default save location based on user selecting different video qualities
        private void videoQualityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoInfo video = videoInfos[videoQualityComboBox.SelectedIndex];
            saveLocationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + video.Title + video.VideoExtension;
        }
     
    }
}

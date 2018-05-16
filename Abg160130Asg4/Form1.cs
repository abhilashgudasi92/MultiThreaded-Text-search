/* This program is written to read a text file and search for the text user wants to search for.
 * Result is displayed in List view with the line number and the entire line in which the search text is present.
 * Here we also display the number of lines mathched along with the time it took to search in hh:mm:ss:ff format.
 * Respective tasks in progress are updated in status label accordingly.
 * 
    Written by: Abhilash Gudasi - abg160130@utdallas.edu
    NetID: abg160130
*/

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Media;
using System.Drawing;

namespace Abg160130Asg4
{
    public partial class Form1 : Form
    {
        //background worker object for background thread 
        BackgroundWorker stringSearch;

        //notify sound object
        SoundPlayer notifySound;

        //count of the number of lines already found from the input file
        int count = 0;

        //Stopwatch to get the time taken to search all the string
        System.Diagnostics.Stopwatch elapseTime = new System.Diagnostics.Stopwatch();

        TimeSpan totalTime;

        //Status displays
        const string SEARCH_TEXT = "Searching text...";

        const string CANCELLED_SEARCH = "[Cancelled]Search has been cancelled";

        const string COMPLETED_SEARCH = "[Completed]Search has been completed";

        const string NO_LINES_FOUND = "[no matching line(s) are found]";

        const string ERROR_TEXT = "[Error occured] while performing background operation";

        const string SEARCH = "Search";

        const string CANCEL = "Cancel";

        public Form1()
        {
            InitializeComponent();

            this.CenterToScreen();

            //Initially number of lines matched is zero
            this.textBoxLineMatched.Text = "0";
            this.textBoxTime.Text = "0";

            //new background worker object for searching the string
            stringSearch = new BackgroundWorker();

            stringSearch.DoWork += new DoWorkEventHandler(stringSearchBackground);
            stringSearch.RunWorkerCompleted += new RunWorkerCompletedEventHandler(stringSearchBackgroundCompleted);
            stringSearch.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            stringSearch.WorkerReportsProgress = true;
            stringSearch.WorkerSupportsCancellation = true;
        }

        //Event handler to search for the string in the document and fill the list view accordingly
        private void stringSearchBackground(object sender, DoWorkEventArgs e)
        {
            string file = textBoxFileName.Text;
            string searchString = textBoxSearch.Text;

            //clear list view
            if (listView1.Items.Count > 0)
                this.Invoke((MethodInvoker)(() => listView1.Items.Clear()));

            using (StreamReader reader = File.OpenText(file))
            {
                string line;
                int percComplete=0;
                //Keep track of the line number which needs to be displayed in the list view
                int lineNo = 1;

                int length = (int) new System.IO.FileInfo(file).Length;
                try
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line) && line.ToLower().Contains(searchString.ToLower()))
                        {
                            count++;
                            this.Invoke((MethodInvoker)(() =>
                                            listView1.Items.Add(new ListViewItem(new[] { lineNo.ToString(), line }))));
                            this.Invoke((MethodInvoker)(() => textBoxLineMatched.Text = count.ToString()));
                        }


                        //If the user clicks "Cancel", the CancellationPending flag is set to true
                        if (stringSearch.CancellationPending)
                        {
                            // Set the e.Cancel flag so that the WorkerCompleted event knows that the process was cancelled
                            e.Cancel = true;
                            return;
                        }

                        // progress bar implementation 
                        if (line.Length != 0 && (lineNo % 100 == 0))
                        {
                            percComplete = calculateSize(line.Length, lineNo, length);
                            stringSearch.ReportProgress(percComplete);
                        }

                        Thread.Sleep(1);        //1 millisec pause everytime I read a line
                        lineNo++;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("[Error]: Could not read file/search error. Original error: " + ex.Message);
                }
            }

        }

        //Function to calculate how many percent of file has been searched so far
        private int calculateSize(int lineLength, int lineNo, int fileLength)
        {
            int percComplete;
            percComplete = ((lineNo*4834) /fileLength);         //lineno*48*100/fileLength
            Console.WriteLine("Inside :" + lineNo + " "+ fileLength + " "+percComplete);
            return percComplete;
        }

        //Updating the progress bar
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
            toolStripStatusLabel2.Text = e.ProgressPercentage.ToString() + "%";
        }

        //Event handler to do appropriate task on completion
        private void stringSearchBackgroundCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Check to see if cancellation was requested
            if (e.Cancelled)
            {
               toolStripStatusLabel1.Text = CANCELLED_SEARCH;
               toolStripStatusLabel1.ForeColor = Color.Red;

                //Plays the cancelled sound to notify the user
                notifySound = new SoundPlayer(Properties.Resources.searchCancelled);
            }

            //Check to see if an error occurred in the background process
            else if (e.Error != null)
            {
                toolStripStatusLabel1.Text = ERROR_TEXT;
                toolStripStatusLabel1.ForeColor = Color.Red;
            }

            else
            {
                //StopWatch stop
                elapseTime.Stop();

                totalTime = elapseTime.Elapsed;

                //If no lines match the search text, the number of lines is shown as '0'
                if (count == 0)
                {
                    textBoxLineMatched.Text = count.ToString();
                    toolStripStatusLabel1.Text = COMPLETED_SEARCH + NO_LINES_FOUND;
                }
                else
                    toolStripStatusLabel1.Text = COMPLETED_SEARCH;

                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripProgressBar1.Value = 100;
                toolStripStatusLabel2.Text = 100 + "%";
                buttonSearch.Text = SEARCH;
                //Update total time taken
                textBoxTime.Text = totalTime.ToString();

                //Reset number of matches and total time 
                count = 0;
                elapseTime.Reset();
                totalTime = TimeSpan.Zero;

                //Plays the completion sound to notify the user
                notifySound = new SoundPlayer(Properties.Resources.searchCompleted);
            }
            notifySound.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    textBoxFileName.Text = fileName;

                    //clear the view since a new search is being requested
                    this.textBoxSearch.Text = String.Empty;
                    this.toolStripStatusLabel1.Text = String.Empty;
                    this.toolStripStatusLabel2.Text = 0 + "%";
                    this.textBoxLineMatched.Text = "0";
                    this.listView1.Items.Clear();
                    this.textBoxTime.Text = "0";
                    this.toolStripProgressBar1.Value = 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        //When search button is clicked
        //we call the background thread here 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (buttonSearch.Text == CANCEL && stringSearch.IsBusy)
            {
                //Notify the worker thread that a cancel has been requested
                stringSearch.CancelAsync();

                //StopWatch stop
                elapseTime.Stop();
                totalTime = elapseTime.Elapsed;

                //Updating respective fields for users
                buttonSearch.Text = SEARCH;
                textBoxTime.Text = totalTime.ToString();

            }
            else
            {
                //The "Search" button text is changed to "Cancel"
                buttonSearch.Text = CANCEL;

                totalTime = TimeSpan.Zero;
                //Start stopwatch
                elapseTime.Reset();
                elapseTime.Start();

                toolStripStatusLabel1.Text = SEARCH_TEXT;
                toolStripStatusLabel1.ForeColor = Color.Black;
                toolStripStatusLabel2.Text = 0 + "%";

                this.textBoxLineMatched.Text = "0";
                this.textBoxTime.Text = "0";

                toolStripProgressBar1.Maximum = 100;
                toolStripProgressBar1.Step = 1;
                toolStripProgressBar1.Value = 0;

                //Start background thread to begin searching for string in the file
                stringSearch.RunWorkerAsync();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                //Enable the button"
                buttonSearch.Enabled = true;
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
                //Disable the button since no text is entered
                buttonSearch.Enabled = false;
        }
    }
}

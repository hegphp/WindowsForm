namespace Notepad {
    public partial class Form1 : Form {
        private bool isChanged;
        private bool changePending = false;

        private string filePath;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        //Close file
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (isChanged) {
                //Confimation if user want to save or not
                DialogResult result = MessageBox.Show("Do you want to save file?", "Confirmation", MessageBoxButtons.YesNoCancel);
                //check if user choose yes or not
                if (result == DialogResult.Yes) {
                    //Check if the filePath is null or not
                    if (filePath == null) {
                        saveToolStripMenuItem_Click(sender, e);
                    }
                    else
                        saveFile(filePath, richTextBox1);
                }
                //check if user choose cancel or not
                else if (result == DialogResult.No) {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = false;
        }
        //Read file
        private void readFromFile(string fileName, RichTextBox text) {
            try {
                using (StreamReader reader = new StreamReader(fileName)) {
                    string line;
                    int count = 0;
                    //Access every line in the file
                    while ((line = reader.ReadLine()) != null) {
                        text.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Cannot read this file\nError: {ex.Message}");
            }
        }
        //Save file from Textbox
        private void saveFile(string fileName, RichTextBox text) {
            try {
                using (StreamWriter writer = new StreamWriter(fileName)) {
                    writer.Write(text.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Cannot write this file\nError: {ex.Message}");
            }
        }
        //Open a text file
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            //Create an object
            OpenFileDialog openFile = new OpenFileDialog();
            //gan property 
            openFile.Multiselect = false; // Default
            openFile.InitialDirectory = @"E:\";
            openFile.Filter = "Text file|*.txt"; //Dinh nghia ngan cach nhau bang dau |
            //Show Dialog
            DialogResult result = openFile.ShowDialog();
            //Check if the result is ok or not
            if (result == DialogResult.OK) {
                filePath = openFile.FileName;
                readFromFile(filePath, richTextBox1);
                isChanged = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        //New file function
        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Text = "";
            filePath = null;
            isChanged = false;
        }
        //Save file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            ////check if user change the file or not
            //if (isChanged == true) {
            //Check if the file is existed or not
            if (filePath == null) {
                //Display a dialog to ask user where to save

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Text file|*.txt";

                DialogResult folderResult = saveFileDialog.ShowDialog();

                //save File path
                filePath = saveFileDialog.FileName;

                if (folderResult == DialogResult.OK) {
                    saveFile(filePath, richTextBox1);
                }
            }
            else
                saveFile(filePath, richTextBox1);
            //}
            isChanged = false;
        }
        //Set changed status when user change the file
        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            this.isChanged = true;
        }
        //Create new File then saves
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            //Display dialog to get new file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            //save file
            DialogResult result = saveFileDialog.ShowDialog();
            //Check if the new file can be created or not
            if (result != DialogResult.OK) {
                saveFile(saveFileDialog.FileName, richTextBox1);
                //Change filepath and status like the begining
                filePath = saveFileDialog.FileName;
                isChanged = false;
            }
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size + 2.0F,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size - 2.0F,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void wordWarpToolStripMenuItem_Click(object sender, EventArgs e) {
            //Check if the wordWarp is enable or not
            if (richTextBox1.WordWrap == false) {
                richTextBox1.WordWrap = true;
            }
            else {
                richTextBox1.WordWrap = false;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.SelectedText += Clipboard.GetText();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.SelectedText += DateTime.Now.ToString();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e) {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter words:", "Find:", "", 0, 0);

            int startIndex = 0;

            while (startIndex < richTextBox1.TextLength) {
                int wordStartIndex = richTextBox1.Find(input, startIndex, RichTextBoxFinds.None);

                if (wordStartIndex != -1) {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionLength = input.Length;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
                else
                    break;
                startIndex = wordStartIndex + input.Length;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NotepadSharp
{
    public sealed partial class MainWindow : Form
    {
        private const string DialogFilters = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

        private readonly List<string> textHistory = new List<string>();
        private int historyIndex = 0;
        private string originText;

        private int currentLine;
        private int currentColumn;
        
        public MainWindow()
        {
            InitializeComponent();
            CenterToParent();
            OnNewDocumentLoad();
        }


        private void OnNewDocumentLoad()
        {
            originText = txtEditBox.Text;
        }

        private void OnCloseOptionPressed(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            string newText = (sender as RichTextBox).Text;
            if (historyIndex < textHistory.Count) textHistory.RemoveRange(historyIndex, textHistory.Count);
            textHistory.Insert(historyIndex++, newText);
            UpdatePositionLabel(sender as RichTextBox);
        }

        private void OnHistoryAction(object sender, EventArgs e)
        {
            String actionName = sender.ToString();
            this.txtEditBox.TextChanged -= new System.EventHandler(this.OnTextChanged);

            switch (actionName.ToLower())
            {
                case "undo":
                    {
                        if (historyIndex >= 1) txtEditBox.Text = textHistory[historyIndex-- - 1];
                        else txtEditBox.Text = originText;
                    }
                    break;
                case "redo":
                    {
                        if (historyIndex <= textHistory.Count - 1) txtEditBox.Text = textHistory[++historyIndex - 1];
                    }
                    break;
            }

            this.txtEditBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            UpdatePositionLabel(txtEditBox);
        }

        private void OnSaveAction(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = DialogFilters,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                TextWriter textWriter = null;
                try
                {
                    textWriter = new StreamWriter(path);
                    textWriter.Write(txtEditBox.Text);
                }
                finally
                {
                    if (textWriter != null)
                    {
                        textWriter.Close();
                    }
                }
            }
        }

        private void OnLoadAction(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = DialogFilters,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                TextReader textReader = null;
                try
                {
                    textReader = new StreamReader(path);
                    txtEditBox.Text = textReader.ReadToEnd();
                }
                finally
                {
                    if (textReader != null)
                    {
                        textReader.Close();
                    }
                }
            }
        }

        private void OnZoomInAction(object sender, EventArgs e)
        {
            txtEditBox.ZoomFactor += .5f;
            UpdateZoomLabel();
        }

        private void OnZoomOutAction(object sender, EventArgs e)
        {
            txtEditBox.ZoomFactor -= .5f;
            UpdateZoomLabel();
        }

        private void OnTextEditKeyPressed(object sender, PreviewKeyDownEventArgs e) => UpdateZoomLabel();


        private void UpdateZoomLabel()
        {
            zoomLbl.Text = string.Format("{0}%", txtEditBox.ZoomFactor * 100);
        }

        private void UpdatePositionLabel(RichTextBox textBox)
        {
            int currentChar = textBox.SelectionStart;
            currentLine = textBox.GetLineFromCharIndex(currentChar);

            // update current col
            int firstRowChar = textBox.GetFirstCharIndexFromLine(currentLine);
            currentColumn = currentChar - firstRowChar;

            // update label
            posLbl.Text = string.Format("Ln {0}, Col {1}", currentLine + 1, currentColumn + 1);
        }
    }
}

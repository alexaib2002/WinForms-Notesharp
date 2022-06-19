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
            string actionName = sender.ToString();
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

        private void OnSaveLoadAction(object sender, EventArgs e)
        {
            string actionName = sender.ToString().ToLower();
            FileDialog dialog = null;
            switch (actionName)
            {
                case "save":
                    {
                        dialog = new SaveFileDialog
                        {
                            Filter = DialogFilters,
                            RestoreDirectory = true
                        };
                    }
                    break;
                case "load":
                    {
                        dialog = new OpenFileDialog
                        {
                            Filter = DialogFilters,
                            RestoreDirectory = true
                        };
                    }
                    break;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                switch (actionName)
                {
                    case "save":
                        {
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
                        break;
                    case "load":
                        {
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
                        break;
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

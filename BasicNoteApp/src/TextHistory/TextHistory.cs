using System.Collections.Generic;

namespace NoteSharp
{
    internal sealed class TextHistory
    {
        private readonly List<string> textHistory = new List<string>();

        private int historyIndex = 0;
        private string originText;

        public void ResetHistory(string baseText)
        {
            historyIndex = 0;
            textHistory.Clear();
            originText = baseText;
        }

        public void AppendElement(string element)
        {
            if (historyIndex < textHistory.Count) TruncateHistory();
            textHistory.Insert(historyIndex++, element);
        }

        public bool CanRedoHistory() => historyIndex <= textHistory.Count - 1;

        public string RedoHistory() => textHistory[++historyIndex - 1];

        public string UndoHistory()
        {
            if (historyIndex >= 1)
            {
                return textHistory[historyIndex-- - 1];
            }
            return originText;
        }

        private void TruncateHistory() => textHistory.RemoveRange(historyIndex, textHistory.Count);

    }
}

namespace NotepadSharp
{
    partial class MainWindow
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
            this.txtEditBox = new System.Windows.Forms.RichTextBox();
            this.footPanel = new System.Windows.Forms.TableLayoutPanel();
            this.posLbl = new System.Windows.Forms.Label();
            this.zoomLbl = new System.Windows.Forms.Label();
            this.encodingLbl = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTextEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel = new System.Windows.Forms.MenuStrip();
            this.footPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditBox
            // 
            this.txtEditBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditBox.Location = new System.Drawing.Point(0, 24);
            this.txtEditBox.Name = "txtEditBox";
            this.txtEditBox.Size = new System.Drawing.Size(576, 440);
            this.txtEditBox.TabIndex = 2;
            this.txtEditBox.Text = "";
            this.txtEditBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.txtEditBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnTextEditKeyPressed);
            // 
            // footPanel
            // 
            this.footPanel.AutoSize = true;
            this.footPanel.ColumnCount = 3;
            this.footPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.footPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.footPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.footPanel.Controls.Add(this.posLbl, 0, 0);
            this.footPanel.Controls.Add(this.zoomLbl, 1, 0);
            this.footPanel.Controls.Add(this.encodingLbl, 2, 0);
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footPanel.Location = new System.Drawing.Point(0, 445);
            this.footPanel.Name = "footPanel";
            this.footPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.footPanel.RowCount = 1;
            this.footPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footPanel.Size = new System.Drawing.Size(576, 19);
            this.footPanel.TabIndex = 4;
            // 
            // posLbl
            // 
            this.posLbl.AutoSize = true;
            this.posLbl.Location = new System.Drawing.Point(20, 3);
            this.posLbl.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.posLbl.Name = "posLbl";
            this.posLbl.Size = new System.Drawing.Size(58, 13);
            this.posLbl.TabIndex = 0;
            this.posLbl.Text = "Ln 1, Col 1";
            // 
            // zoomLbl
            // 
            this.zoomLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zoomLbl.AutoSize = true;
            this.zoomLbl.Location = new System.Drawing.Point(429, 3);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.Size = new System.Drawing.Size(33, 13);
            this.zoomLbl.TabIndex = 1;
            this.zoomLbl.Text = "100%";
            // 
            // encodingLbl
            // 
            this.encodingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.encodingLbl.AutoSize = true;
            this.encodingLbl.Location = new System.Drawing.Point(514, 3);
            this.encodingLbl.Name = "encodingLbl";
            this.encodingLbl.Size = new System.Drawing.Size(37, 13);
            this.encodingLbl.TabIndex = 2;
            this.encodingLbl.Text = "UTF-8";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewDocumentCreated);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "Load";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnSaveLoadAction);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveLoadAction);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnCloseOptionPressed);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.OnHistoryAction);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.OnHistoryAction);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.OnZoomInAction);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.OnZoomOutAction);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTextEditorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutTextEditorToolStripMenuItem
            // 
            this.aboutTextEditorToolStripMenuItem.Name = "aboutTextEditorToolStripMenuItem";
            this.aboutTextEditorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutTextEditorToolStripMenuItem.Text = "About NoteSharp";
            // 
            // menuPanel
            // 
            this.menuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(576, 24);
            this.menuPanel.TabIndex = 3;
            this.menuPanel.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(576, 464);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.txtEditBox);
            this.Controls.Add(this.menuPanel);
            this.MainMenuStrip = this.menuPanel;
            this.Name = "MainWindow";
            this.Text = "NoteSharp";
            this.footPanel.ResumeLayout(false);
            this.footPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtEditBox;
        private System.Windows.Forms.TableLayoutPanel footPanel;
        private System.Windows.Forms.Label posLbl;
        private System.Windows.Forms.Label zoomLbl;
        private System.Windows.Forms.Label encodingLbl;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTextEditorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuPanel;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
    }
}


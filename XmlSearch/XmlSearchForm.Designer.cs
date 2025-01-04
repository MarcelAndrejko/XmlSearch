namespace XmlSearch
{
    partial class XmlSearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlSearchForm));
            toolStrip1 = new ToolStrip();
            startSearchBtn = new ToolStripButton();
            stopSearchBtn = new ToolStripButton();
            SaveBtn = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            fileToolStripStatusLabel = new ToolStripStatusLabel();
            currentToolStripStatusLabel = new ToolStripStatusLabel();
            ofToolStripStatusLabel = new ToolStripStatusLabel();
            totalToolStripStatusLabel = new ToolStripStatusLabel();
            processingToolStripStatusLabel = new ToolStripStatusLabel();
            filenameToolStripStatusLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            selectXmlDirectoryBtn = new Button();
            pathTextBox = new TextBox();
            resultTextBox = new TextBox();
            globalSearchCheckBox = new CheckBox();
            regExpComboBox = new ComboBox();
            xPathComboBox = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { startSearchBtn, stopSearchBtn, SaveBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1059, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // startSearchBtn
            // 
            startSearchBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            startSearchBtn.Image = (Image)resources.GetObject("startSearchBtn.Image");
            startSearchBtn.ImageTransparentColor = Color.Magenta;
            startSearchBtn.Name = "startSearchBtn";
            startSearchBtn.Size = new Size(72, 22);
            startSearchBtn.Text = "Start search";
            startSearchBtn.ToolTipText = "Open";
            startSearchBtn.Click += startSearchBtn_Click;
            // 
            // stopSearchBtn
            // 
            stopSearchBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            stopSearchBtn.Enabled = false;
            stopSearchBtn.Image = (Image)resources.GetObject("stopSearchBtn.Image");
            stopSearchBtn.ImageTransparentColor = Color.Magenta;
            stopSearchBtn.Name = "stopSearchBtn";
            stopSearchBtn.Size = new Size(78, 22);
            stopSearchBtn.Text = "Abort search";
            stopSearchBtn.Click += stopSearchBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SaveBtn.Image = (Image)resources.GetObject("SaveBtn.Image");
            SaveBtn.ImageTransparentColor = Color.Magenta;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(67, 22);
            SaveBtn.Text = "Save result";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Xml |*.xml";
            openFileDialog1.Multiselect = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, fileToolStripStatusLabel, currentToolStripStatusLabel, ofToolStripStatusLabel, totalToolStripStatusLabel, processingToolStripStatusLabel, filenameToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 599);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1059, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // fileToolStripStatusLabel
            // 
            fileToolStripStatusLabel.Name = "fileToolStripStatusLabel";
            fileToolStripStatusLabel.Size = new Size(25, 17);
            fileToolStripStatusLabel.Text = "File";
            // 
            // currentToolStripStatusLabel
            // 
            currentToolStripStatusLabel.Name = "currentToolStripStatusLabel";
            currentToolStripStatusLabel.Size = new Size(13, 17);
            currentToolStripStatusLabel.Text = "0";
            // 
            // ofToolStripStatusLabel
            // 
            ofToolStripStatusLabel.Name = "ofToolStripStatusLabel";
            ofToolStripStatusLabel.Size = new Size(18, 17);
            ofToolStripStatusLabel.Text = "of";
            // 
            // totalToolStripStatusLabel
            // 
            totalToolStripStatusLabel.Name = "totalToolStripStatusLabel";
            totalToolStripStatusLabel.Size = new Size(13, 17);
            totalToolStripStatusLabel.Text = "0";
            // 
            // processingToolStripStatusLabel
            // 
            processingToolStripStatusLabel.Name = "processingToolStripStatusLabel";
            processingToolStripStatusLabel.Size = new Size(67, 17);
            processingToolStripStatusLabel.Text = "Processing:";
            // 
            // filenameToolStripStatusLabel
            // 
            filenameToolStripStatusLabel.Name = "filenameToolStripStatusLabel";
            filenameToolStripStatusLabel.Size = new Size(22, 17);
            filenameToolStripStatusLabel.Text = "---";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(selectXmlDirectoryBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(pathTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(resultTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(globalSearchCheckBox, 1, 3);
            tableLayoutPanel1.Controls.Add(regExpComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(xPathComboBox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1059, 574);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 0;
            label1.Text = "XML directory";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(141, 29);
            label2.TabIndex = 1;
            label2.Text = "Search for nodes (XPath)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 2;
            label3.Text = "Line condition (Reg. exp.)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectXmlDirectoryBtn
            // 
            selectXmlDirectoryBtn.AutoSize = true;
            selectXmlDirectoryBtn.Dock = DockStyle.Right;
            selectXmlDirectoryBtn.Location = new Point(981, 3);
            selectXmlDirectoryBtn.Name = "selectXmlDirectoryBtn";
            selectXmlDirectoryBtn.Size = new Size(75, 25);
            selectXmlDirectoryBtn.TabIndex = 5;
            selectXmlDirectoryBtn.Text = "Select";
            selectXmlDirectoryBtn.UseVisualStyleBackColor = true;
            selectXmlDirectoryBtn.Click += selectXmlDirectoryBtn_Click;
            // 
            // pathTextBox
            // 
            pathTextBox.Dock = DockStyle.Top;
            pathTextBox.Location = new Point(150, 3);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.ReadOnly = true;
            pathTextBox.Size = new Size(825, 23);
            pathTextBox.TabIndex = 6;
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(resultTextBox, 3);
            resultTextBox.Dock = DockStyle.Fill;
            resultTextBox.Location = new Point(3, 117);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Both;
            resultTextBox.Size = new Size(1053, 454);
            resultTextBox.TabIndex = 7;
            resultTextBox.WordWrap = false;
            // 
            // globalSearchCheckBox
            // 
            globalSearchCheckBox.AutoSize = true;
            globalSearchCheckBox.Checked = true;
            globalSearchCheckBox.CheckState = CheckState.Checked;
            tableLayoutPanel1.SetColumnSpan(globalSearchCheckBox, 2);
            globalSearchCheckBox.Location = new Point(150, 92);
            globalSearchCheckBox.Name = "globalSearchCheckBox";
            globalSearchCheckBox.Size = new Size(97, 19);
            globalSearchCheckBox.TabIndex = 8;
            globalSearchCheckBox.Text = "Global search";
            globalSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // regExpComboBox
            // 
            regExpComboBox.AllowDrop = true;
            tableLayoutPanel1.SetColumnSpan(regExpComboBox, 2);
            regExpComboBox.Dock = DockStyle.Top;
            regExpComboBox.FormattingEnabled = true;
            regExpComboBox.Items.AddRange(new object[] { "[^:]*:\\s*$", "^(Nález:)" });
            regExpComboBox.Location = new Point(150, 63);
            regExpComboBox.Name = "regExpComboBox";
            regExpComboBox.Size = new Size(906, 23);
            regExpComboBox.TabIndex = 9;
            // 
            // xPathComboBox
            // 
            tableLayoutPanel1.SetColumnSpan(xPathComboBox, 2);
            xPathComboBox.Dock = DockStyle.Top;
            xPathComboBox.FormattingEnabled = true;
            xPathComboBox.Items.AddRange(new object[] { "//vr[nazev_lclp='Laboratorní nález obecný']/vrr/text/ptext/text()", "//*/text()" });
            xPathComboBox.Location = new Point(150, 34);
            xPathComboBox.Name = "xPathComboBox";
            xPathComboBox.Size = new Size(906, 23);
            xPathComboBox.TabIndex = 10;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            // 
            // XmlSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 621);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "XmlSearchForm";
            Text = "XmlSearch";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton startSearchBtn;
        private OpenFileDialog openFileDialog1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel fileToolStripStatusLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button selectXmlDirectoryBtn;
        private TextBox pathTextBox;
        private TextBox resultTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox globalSearchCheckBox;
        private ToolStripStatusLabel currentToolStripStatusLabel;
        private ToolStripStatusLabel ofToolStripStatusLabel;
        private ToolStripStatusLabel totalToolStripStatusLabel;
        private ToolStripStatusLabel processingToolStripStatusLabel;
        private ToolStripStatusLabel filenameToolStripStatusLabel;
        private ToolStripButton stopSearchBtn;
        private ComboBox regExpComboBox;
        private ToolStripButton SaveBtn;
        private SaveFileDialog saveFileDialog1;
        private ComboBox xPathComboBox;
    }
}

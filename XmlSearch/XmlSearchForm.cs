using System.Text;
using System.Text.RegularExpressions;

namespace XmlSearch
{
    public partial class XmlSearchForm : Form
    {
        private SearchJob? SearchJob { get; set; } = null;

        public XmlSearchForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private static string[] RenderResult(Dictionary<string, HashSet<string>> value)
        {
            var result = new List<string>();
            var sorted1 = value.Keys.OrderBy(x => x).ToArray();

            foreach (var k in sorted1)
            {
                if (value[k].Count == 0)
                    continue;

                result.Add(k);
                var sorted2 = value[k].OrderBy(x => x).ToArray();
                foreach (var v in sorted2)
                    result.Add(v);
                result.Add("");
            }
            return result.ToArray();
        }

        private void stopSearchBtn_Click(object sender, EventArgs e)
        {
            this.SearchJob?.Abort();
        }

        private void startSearchBtn_Click(object sender, EventArgs e)
        {
            this.regExpComboBox.Enabled = false;
            this.xPathComboBox.Enabled = false;
            this.selectXmlDirectoryBtn.Enabled = false;
            this.startSearchBtn.Enabled = false;
            this.globalSearchCheckBox.Enabled = false;
            this.stopSearchBtn.Enabled = true;
            this.SaveBtn.Enabled = false;

            try
            {
                this.SearchJob = new SearchJob(
                    this.pathTextBox.Text,
                    this.xPathComboBox.Text,
                    string.IsNullOrWhiteSpace(this.regExpComboBox.Text) ? null : new Regex(this.regExpComboBox.Text.Trim()),
                    this.globalSearchCheckBox.Checked,
                    (count, all, file) =>
                    {
                        this.currentToolStripStatusLabel.Text = count.ToString();
                        this.totalToolStripStatusLabel.Text = all.ToString();
                        this.filenameToolStripStatusLabel.Text = file ?? "---";
                        this.toolStripProgressBar1.Maximum = all;
                        this.toolStripProgressBar1.Value = count;
                        Application.DoEvents();
                    },
                    (result) =>
                    {
                        this.resultTextBox.Lines = RenderResult(result);
                        Application.DoEvents();
                    });
                this.SearchJob.Do();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Application.DoEvents();
            }
            finally
            {
                this.regExpComboBox.Enabled = true;
                this.xPathComboBox.Enabled = true;
                this.selectXmlDirectoryBtn.Enabled = true;
                this.startSearchBtn.Enabled = true;
                this.globalSearchCheckBox.Enabled = true;
                this.stopSearchBtn.Enabled = false;
                this.SaveBtn.Enabled = true;

                Application.DoEvents();
            }
        }

        private void selectXmlDirectoryBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            this.pathTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            System.IO.File.WriteAllText(this.saveFileDialog1.FileName, this.resultTextBox.Text ?? "");
        }
    }
}

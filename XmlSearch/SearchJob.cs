using System.Text.RegularExpressions;
using System.Xml;

namespace XmlSearch
{
    public class SearchJob
    {
        private string Folder {  get; set; }
        private string XPath { get; set; }
        private Regex? Regex { get; set; }
        private bool GlobalSearch { get; set; }
        private Dictionary<string, HashSet<string>> Result { get; set; }
        private Action<int, int, string?> ProgressCallback { get; set; }
        private Action<Dictionary<string, HashSet<string>>> ResultCallback { get; set; }
        private bool Aborted { get; set; }

        public SearchJob(
            string folder, 
            string xpath,
            Regex? regex, 
            bool globalSearch,
            Action<int, int, string?> ProgressCallback,
            Action<Dictionary<string, HashSet<string>>> ResultCallback) {

            this.Folder = folder;
            this.XPath = xpath;
            this.GlobalSearch = globalSearch;
            this.Regex = regex;
            this.Result = new Dictionary<string, HashSet<string>>();
            this.ProgressCallback = ProgressCallback;
            this.ResultCallback = ResultCallback;
        }

        public void Abort()
        {
            this.Aborted = true;
        }

        public void Do()
        {
            this.Aborted = false;
            this.Result = new Dictionary<string, HashSet<string>>();
            this.ResultCallback(this.Result);
            this.ProgressCallback(0, 0, null);

            if (string.IsNullOrWhiteSpace(this.Folder))
            {
                throw new Exception("Folder is empty");
            }

            if (string.IsNullOrWhiteSpace(this.XPath))
            {
                throw new Exception("XPath is empty");
            }

            try
            {
                string[] files = Directory.GetFiles(this.Folder);

                this.ProgressCallback(0, files.Count(), null);

                var counter = 0;
                foreach (var file in files)
                {

                    counter++;
                    this.ProgressCallback(counter, files.Length, file);

                    string key = file;
                    if (this.GlobalSearch)
                    {
                        key = Path.GetDirectoryName(key) ?? "";
                    }

                    if (!this.Result.ContainsKey(key))
                    {
                        this.Result[key] = new HashSet<string>();
                    }

                    HashSet<string> result1 = this.Result[key];

                    XmlDocument doc = new XmlDocument();
                    byte[] content = File.ReadAllBytes(file);
                    using (MemoryStream ms = new MemoryStream(content))
                    {
                        doc.Load(ms);
                    }


                    var nodes = doc.SelectNodes(this.XPath);
                    if (nodes != null)
                    {
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            XmlNode? node = nodes[i];
                            var str = node?.Value ?? "";

                            if (this.Regex == null)
                            {
                                result1.Add(str);
                                this.ResultCallback(this.Result);
                            }
                            else
                            {
                                StringReader sr = new StringReader(str);
                                string? row = null;
                                while ((row = sr.ReadLine()) != null)
                                {
                                    row = row.Trim();
                                    if (this.Regex.IsMatch(row))
                                    {
                                        result1.Add(row);
                                        this.ResultCallback(this.Result);
                                    }
                                }
                            }

                            if (this.Aborted)
                            {
                                throw new AbortException();
                            }
                        }
                    }

                    if (this.Aborted)
                    {
                        throw new AbortException();
                    }
                }

                this.ProgressCallback(files.Count(), files.Count(), null);
            }
            catch (AbortException)
            {
                // ignore
            }
            finally
            {
                this.ResultCallback(this.Result);
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GMLocalize2 {
    public partial class ProgramWindow : Form {
        private const string CODE_FILE_EXT = "*.gml";
        public string LocalizeSymbol {
            get; set;
        } = "__";

        public List<string> AllLanguages {
            get; set;
        } = new List<string>();

        public ProgramWindow() {
            InitializeComponent();
            AllLanguages.Add("English");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            using (OpenFileDialog finder = new OpenFileDialog()) {
                finder.Filter = "GameMaker Studio 2 projects (*.yyp)|*.yyp";

                if (finder.ShowDialog() == DialogResult.OK) {
                    Reset();
                    Extract(finder.FileName, Program.window.LocalizeSymbol);
                }
            }
        }

        private void buttonSortAZ_Click(object sender, EventArgs e) {
            string[] items = new string[listText.Items.Count];
            listText.Items.CopyTo(items, 0);
            Reset();
            Array.Sort(items, delegate (string a, string b) {
                return a.CompareTo(b);
            });
            foreach (string text in items) {
                listText.Items.Add(text);
            }
        }

        private void buttonSortLength_Click(object sender, EventArgs e) {
            string[] items = new string[listText.Items.Count];
            listText.Items.CopyTo(items, 0);
            Reset();
            Array.Sort(items, delegate (string a, string b) {
                return a.Length.CompareTo(b.Length);
            });
            foreach (string text in items) {
                listText.Items.Add(text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            Reset();
        }

        private void buttonExport_Click(object sender, EventArgs e) {
            using (SaveFileDialog finder = new SaveFileDialog()) {
                finder.Filter = "JSON or CSV|*.csv;*.json|JavaScript Object Notation (*.json)|*.json|Comma-Separated Value sheets (*.csv)|*.csv";

                if (finder.ShowDialog() == DialogResult.OK) {
                    switch (new FileInfo(finder.FileName).Extension.ToLower()) {
                        case ".json":
                            string json = "{\n";
                            json += "    \"available\": [\n";
                            foreach (string language in AllLanguages) {
                                json += "        {\n";
                                json += "            \"name\": \"" + language + "\",\n";
                                json += "            \"strings\": {\n";
                                foreach (string item in listText.Items) {
                                    json += "                \"" + item + "\": \"" + item + "\",\n";
                                }
                                json = json.Substring(0, json.Length - 2);
                                json += "\n";
                                json += "            }\n";
                                json += "        },\n";
                            }
                            json = json.Substring(0, json.Length - 2) + "\n";
                            json += "    ]\n";
                            json += "}\n";
                            File.WriteAllText(finder.FileName, json);
                            break;
                        case ".csv":
                            string csv = "\"default\",";
                            foreach (string lang in AllLanguages) {
                                csv += "\"" + lang + "\",";
                            }
                            csv = csv.Substring(0, csv.Length - 1);
                            csv += "\n";
                            foreach (string item in listText.Items) {
                                csv += "\"" + item + "\",\"" + item  + "\",";
                                for (int i = 1; i < AllLanguages.Count; i++) {
                                    csv += "\"\"";
                                    if (i < AllLanguages.Count - 1) {
                                        csv += ",";
                                    }
                                }
                                csv += "\n";
                            }
                            File.WriteAllText(finder.FileName, csv);
                            break;
                    }
                }
            }
        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e) {
            Program.window.LocalizeSymbol = textBoxSymbol.Text;
        }

        private void buttonSettings_Click(object sender, EventArgs e) {
            new FormSettings().Show();
        }

        #region Actions
        private void Extract(string directory, string localizeFunction) {
            DirectoryInfo root = new DirectoryInfo(Path.GetDirectoryName(directory));
            Regex re = new Regex(@"([\+\-\*\(\)\^\\\%\[\]\(\)\=\;\,])");
            HashSet<string> allText = new HashSet<string>();
            foreach (FileInfo filename in root.GetFiles(CODE_FILE_EXT, SearchOption.AllDirectories)) {
                string[] stripped = RemoveComments(File.ReadAllLines(filename.FullName));
                bool adding = false;
                string text = "";
                foreach (string line in stripped) {
                    string[] tokens = re.Split(line);
                    for (int i = 0; i < tokens.Length; i++) {
                        if (adding) {
                            text += tokens[i];
                            if (text.Length > 1 && tokens[i].Length > 0 && tokens[i].EndsWith("\"")) {
                                adding = false;
                                allText.Add(text.Substring(1, text.Length - 2));
                                text = "";
                            }
                        } else {
                            if (tokens[i].Trim() == localizeFunction) {
                                adding = true;
                                i++;
                            }
                        }
                    }
                }
            }

            foreach (string item in allText) {
                listText.Items.Add(item);
            }
        }

        private void Reset() {
            listText.Items.Clear();
        }

        private string[] RemoveComments(string[] lines) {
            // it would probably be faster to supply a single string and remove
            // block comments before line comments, but unfortunately a block
            // comment that begins or ends inside a line comment does not count
            for (int i = 0; i < lines.Length; i++) {
                for (int j = 1; j < lines[i].Length; j++) {
                    if (lines[i][j] == '/' && lines[i][j - 1] == '/') {
                        lines[i] = lines[i].Substring(0, j - 1);
                        break;
                    }
                }
            }
            string single = string.Join("\n", lines);

            const string commentStart = "/*";
            const string commentEnd = "*/";
            while (single.IndexOf(commentStart) > -1 && single.IndexOf(commentEnd, single.IndexOf(commentStart) + commentStart.Length) > -1) {
                int start = single.IndexOf(commentStart);
                int end = single.IndexOf(commentEnd, start + commentStart.Length);
                single = single.Remove(start, (end + commentEnd.Length) - start);
            }

            return single.Split('\n');
        }
        #endregion
    }
}

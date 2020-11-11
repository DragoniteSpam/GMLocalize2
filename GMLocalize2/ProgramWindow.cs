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
        public ProgramWindow() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            using (OpenFileDialog finder = new OpenFileDialog()) {
                finder.Filter = "GameMaker Studio 2 projects (*.yyp)|*.yyp";

                if (finder.ShowDialog() == DialogResult.OK) {
                    DirectoryInfo root = new DirectoryInfo(Path.GetDirectoryName(finder.FileName));
                    Regex re = new Regex(@"([\+\-\*\(\)\^\\\%\[\]\(\)\=\;])");
                    foreach (FileInfo filename in root.GetFiles("*.gml", SearchOption.AllDirectories)) {
                        string[] stripped = removeComments(File.ReadAllLines(filename.FullName));
                        
                    }
                }
            }
        }

        private string[] removeComments(string[] lines) {
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
    }
}

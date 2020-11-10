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
                    int i = 0;
                    foreach (FileInfo filename in root.GetFiles("*.gml", SearchOption.AllDirectories)) {
                        /* behave */
                    }
                }
            }
        }
    }
}

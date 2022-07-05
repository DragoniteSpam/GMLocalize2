using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GMLocalize2 {
    public partial class ProgramWindow : Form {
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
            Open();
        }

        private void buttonSortAZ_Click(object sender, EventArgs e) {
            SortAZ();
        }

        private void buttonSortLength_Click(object sender, EventArgs e) {
            SortLength();
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            Reset();
        }

        private void buttonExport_Click(object sender, EventArgs e) {
            Export();
        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e) {
            Program.window.LocalizeSymbol = textBoxSymbol.Text;
        }

        private void buttonSettings_Click(object sender, EventArgs e) {
            new FormSettings().Show();
        }
    }
}

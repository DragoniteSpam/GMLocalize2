using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMLocalize2 {
    public partial class FormSettings : Form {
        public FormSettings() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listText_SelectedIndexChanged(object sender, EventArgs e) {
            if (listLanguageNames.SelectedIndex > -1) {
                textBoxLanguageName.Text = Program.window.AllLanguages[listLanguageNames.SelectedIndex];
            }
        }

        private void buttonLanguageAdd_Click(object sender, EventArgs e) {

        }

        private void buttonLanguageRemove_Click(object sender, EventArgs e) {

        }

        private void textBoxLanguageName_TextChanged(object sender, EventArgs e) {
            Program.window.AllLanguages[listLanguageNames.SelectedIndex]  = textBoxLanguageName.Text;
            listLanguageNames.Items[listLanguageNames.SelectedIndex] = textBoxLanguageName.Text;
        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e) {
            Program.window.LocalizeSymbol = textBoxSymbol.Text;
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

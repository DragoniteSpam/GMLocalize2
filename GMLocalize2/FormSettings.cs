using System;
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
            int index = 0;
            while (Program.window.AllLanguages.Contains("Language" + index)) {
                index++;
            }

            Program.window.AllLanguages.Add("Language" + index);
            listLanguageNames.Items.Add("Language" + index);
        }

        private void buttonLanguageRemove_Click(object sender, EventArgs e) {
            if (listLanguageNames.SelectedIndex > -1) {
                Program.window.AllLanguages.RemoveAt(listLanguageNames.SelectedIndex);
                listLanguageNames.Items.RemoveAt(listLanguageNames.SelectedIndex);
            }
        }

        private void textBoxLanguageName_TextChanged(object sender, EventArgs e) {
            if (listLanguageNames.SelectedIndex > -1) {
                Program.window.AllLanguages[listLanguageNames.SelectedIndex] = textBoxLanguageName.Text;
                listLanguageNames.Items[listLanguageNames.SelectedIndex] = textBoxLanguageName.Text;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

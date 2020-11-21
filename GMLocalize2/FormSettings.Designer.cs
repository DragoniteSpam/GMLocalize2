﻿
namespace GMLocalize2 {
    partial class FormSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.listLanguageNames = new System.Windows.Forms.ListBox();
            this.buttonLanguageAdd = new System.Windows.Forms.Button();
            this.buttonLanguageRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLanguageName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Localization Function:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSymbol.Location = new System.Drawing.Point(217, 12);
            this.textBoxSymbol.MaxLength = 20;
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(155, 27);
            this.textBoxSymbol.TabIndex = 9;
            this.textBoxSymbol.Text = "__";
            this.textBoxSymbol.TextChanged += new System.EventHandler(this.textBoxSymbol_TextChanged);
            // 
            // listLanguageNames
            // 
            this.listLanguageNames.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLanguageNames.FormattingEnabled = true;
            this.listLanguageNames.ItemHeight = 19;
            this.listLanguageNames.Location = new System.Drawing.Point(16, 45);
            this.listLanguageNames.Name = "listLanguageNames";
            this.listLanguageNames.Size = new System.Drawing.Size(356, 232);
            this.listLanguageNames.TabIndex = 11;
            this.listLanguageNames.SelectedIndexChanged += new System.EventHandler(this.listText_SelectedIndexChanged);
            // 
            // buttonLanguageAdd
            // 
            this.buttonLanguageAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLanguageAdd.Location = new System.Drawing.Point(10, 317);
            this.buttonLanguageAdd.Name = "buttonLanguageAdd";
            this.buttonLanguageAdd.Size = new System.Drawing.Size(176, 32);
            this.buttonLanguageAdd.TabIndex = 14;
            this.buttonLanguageAdd.Text = "Add";
            this.buttonLanguageAdd.UseVisualStyleBackColor = true;
            this.buttonLanguageAdd.Click += new System.EventHandler(this.buttonLanguageAdd_Click);
            // 
            // buttonLanguageRemove
            // 
            this.buttonLanguageRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLanguageRemove.Location = new System.Drawing.Point(196, 317);
            this.buttonLanguageRemove.Name = "buttonLanguageRemove";
            this.buttonLanguageRemove.Size = new System.Drawing.Size(176, 32);
            this.buttonLanguageRemove.TabIndex = 12;
            this.buttonLanguageRemove.Text = "Remove";
            this.buttonLanguageRemove.UseVisualStyleBackColor = true;
            this.buttonLanguageRemove.Click += new System.EventHandler(this.buttonLanguageRemove_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Language Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxLanguageName
            // 
            this.textBoxLanguageName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLanguageName.Location = new System.Drawing.Point(217, 283);
            this.textBoxLanguageName.MaxLength = 20;
            this.textBoxLanguageName.Name = "textBoxLanguageName";
            this.textBoxLanguageName.Size = new System.Drawing.Size(155, 27);
            this.textBoxLanguageName.TabIndex = 15;
            this.textBoxLanguageName.TextChanged += new System.EventHandler(this.textBoxLanguageName_TextChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLanguageName);
            this.Controls.Add(this.buttonLanguageAdd);
            this.Controls.Add(this.buttonLanguageRemove);
            this.Controls.Add(this.listLanguageNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSymbol);
            this.Name = "FormSettings";
            this.Text = "GMLocalize Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.ListBox listLanguageNames;
        private System.Windows.Forms.Button buttonLanguageAdd;
        private System.Windows.Forms.Button buttonLanguageRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLanguageName;
    }
}
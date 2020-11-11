namespace GMLocalize2 {
    partial class ProgramWindow {
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listText = new System.Windows.Forms.ListBox();
            this.buttonSortAZ = new System.Windows.Forms.Button();
            this.buttonSortLength = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 66);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(128, 32);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open Project";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(146, 66);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(128, 32);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to GMLocalize!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listText
            // 
            this.listText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listText.FormattingEnabled = true;
            this.listText.ItemHeight = 19;
            this.listText.Location = new System.Drawing.Point(12, 104);
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(460, 308);
            this.listText.TabIndex = 4;
            this.listText.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSortAZ
            // 
            this.buttonSortAZ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortAZ.Location = new System.Drawing.Point(12, 417);
            this.buttonSortAZ.Name = "buttonSortAZ";
            this.buttonSortAZ.Size = new System.Drawing.Size(128, 32);
            this.buttonSortAZ.TabIndex = 5;
            this.buttonSortAZ.Text = "Sort (A-Z)";
            this.buttonSortAZ.UseVisualStyleBackColor = true;
            this.buttonSortAZ.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // buttonSortLength
            // 
            this.buttonSortLength.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortLength.Location = new System.Drawing.Point(146, 417);
            this.buttonSortLength.Name = "buttonSortLength";
            this.buttonSortLength.Size = new System.Drawing.Size(128, 32);
            this.buttonSortLength.TabIndex = 6;
            this.buttonSortLength.Text = "Sort (Length)";
            this.buttonSortLength.UseVisualStyleBackColor = true;
            this.buttonSortLength.Click += new System.EventHandler(this.buttonSortLength_Click);
            // 
            // ProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonSortLength);
            this.Controls.Add(this.buttonSortAZ);
            this.Controls.Add(this.listText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonOpen);
            this.Name = "ProgramWindow";
            this.Text = "GMLocalize";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listText;
        private System.Windows.Forms.Button buttonSortAZ;
        private System.Windows.Forms.Button buttonSortLength;
    }
}


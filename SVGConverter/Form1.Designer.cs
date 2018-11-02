namespace SVGConverter
{
    partial class SvgConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbFolder = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chckbSubDir = new System.Windows.Forms.CheckBox();
            this.chckbDataChange = new System.Windows.Forms.CheckBox();
            this.chckbDataChanging = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSvgFiles = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvgFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbFolder
            // 
            this.txtbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFolder.Enabled = false;
            this.txtbFolder.Location = new System.Drawing.Point(76, 14);
            this.txtbFolder.Name = "txtbFolder";
            this.txtbFolder.Size = new System.Drawing.Size(664, 22);
            this.txtbFolder.TabIndex = 0;
            this.txtbFolder.TextChanged += new System.EventHandler(this.txtbFolder_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chckbSubDir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbFolder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 83);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(761, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор папки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.chckbDataChange);
            this.groupBox1.Controls.Add(this.chckbDataChanging);
            this.groupBox1.Location = new System.Drawing.Point(741, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции конвертирования";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(22, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Конвертировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chckbSubDir
            // 
            this.chckbSubDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chckbSubDir.AutoSize = true;
            this.chckbSubDir.Checked = true;
            this.chckbSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbSubDir.Location = new System.Drawing.Point(750, 50);
            this.chckbSubDir.Name = "chckbSubDir";
            this.chckbSubDir.Size = new System.Drawing.Size(155, 21);
            this.chckbSubDir.TabIndex = 2;
            this.chckbSubDir.Text = "Включая подпапки";
            this.chckbSubDir.UseVisualStyleBackColor = true;
            this.chckbSubDir.CheckedChanged += new System.EventHandler(this.chckbSubDir_CheckedChanged);
            // 
            // chckbDataChange
            // 
            this.chckbDataChange.AutoSize = true;
            this.chckbDataChange.Checked = true;
            this.chckbDataChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbDataChange.Location = new System.Drawing.Point(14, 63);
            this.chckbDataChange.Name = "chckbDataChange";
            this.chckbDataChange.Size = new System.Drawing.Size(109, 21);
            this.chckbDataChange.TabIndex = 1;
            this.chckbDataChange.Text = "DataChange";
            this.chckbDataChange.UseVisualStyleBackColor = true;
            // 
            // chckbDataChanging
            // 
            this.chckbDataChanging.AutoSize = true;
            this.chckbDataChanging.Checked = true;
            this.chckbDataChanging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbDataChanging.Location = new System.Drawing.Point(14, 32);
            this.chckbDataChanging.Name = "chckbDataChanging";
            this.chckbDataChanging.Size = new System.Drawing.Size(120, 21);
            this.chckbDataChanging.TabIndex = 0;
            this.chckbDataChanging.Text = "DataChanging";
            this.chckbDataChanging.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvSvgFiles);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 476);
            this.panel2.TabIndex = 3;
            // 
            // dgvSvgFiles
            // 
            this.dgvSvgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvgFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSvgFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvSvgFiles.Name = "dgvSvgFiles";
            this.dgvSvgFiles.RowTemplate.Height = 24;
            this.dgvSvgFiles.Size = new System.Drawing.Size(717, 474);
            this.dgvSvgFiles.TabIndex = 1;
            // 
            // SvgConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SvgConverterForm";
            this.Text = "Конвертер SVG мнемосхем";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvgFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckbSubDir;
        private System.Windows.Forms.CheckBox chckbDataChange;
        private System.Windows.Forms.CheckBox chckbDataChanging;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSvgFiles;
    }
}


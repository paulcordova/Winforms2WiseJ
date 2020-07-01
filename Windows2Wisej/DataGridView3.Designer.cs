namespace Windows2Wisej
{
    partial class DataGridView3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkColumnsVisible = new System.Windows.Forms.CheckBox();
            this.btnCreateColumns = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkAddSendData = new System.Windows.Forms.CheckBox();
            this.chkResetBindingSource = new System.Windows.Forms.CheckBox();
            this.chkShowDGWScroll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 460);
            this.panel1.TabIndex = 0;
            // 
            // chkColumnsVisible
            // 
            this.chkColumnsVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkColumnsVisible.AutoSize = true;
            this.chkColumnsVisible.Checked = true;
            this.chkColumnsVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColumnsVisible.Location = new System.Drawing.Point(9, 472);
            this.chkColumnsVisible.Name = "chkColumnsVisible";
            this.chkColumnsVisible.Size = new System.Drawing.Size(98, 17);
            this.chkColumnsVisible.TabIndex = 1;
            this.chkColumnsVisible.Text = "Columns visible";
            this.chkColumnsVisible.UseVisualStyleBackColor = true;
            this.chkColumnsVisible.CheckedChanged += new System.EventHandler(this.chkColumnsVisible_CheckedChanged);
            // 
            // btnCreateColumns
            // 
            this.btnCreateColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateColumns.Location = new System.Drawing.Point(315, 466);
            this.btnCreateColumns.Name = "btnCreateColumns";
            this.btnCreateColumns.Size = new System.Drawing.Size(101, 30);
            this.btnCreateColumns.TabIndex = 2;
            this.btnCreateColumns.Text = "&Create Columns";
            this.btnCreateColumns.UseVisualStyleBackColor = true;
            this.btnCreateColumns.Click += new System.EventHandler(this.btnCreateColumns_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadData.Location = new System.Drawing.Point(315, 509);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(101, 30);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "&Load data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkAddSendData
            // 
            this.chkAddSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAddSendData.AutoSize = true;
            this.chkAddSendData.Location = new System.Drawing.Point(9, 495);
            this.chkAddSendData.Name = "chkAddSendData";
            this.chkAddSendData.Size = new System.Drawing.Size(97, 17);
            this.chkAddSendData.TabIndex = 4;
            this.chkAddSendData.Text = "2nd data block";
            this.chkAddSendData.UseVisualStyleBackColor = true;
            // 
            // chkResetBindingSource
            // 
            this.chkResetBindingSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkResetBindingSource.AutoSize = true;
            this.chkResetBindingSource.Checked = true;
            this.chkResetBindingSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResetBindingSource.Location = new System.Drawing.Point(9, 518);
            this.chkResetBindingSource.Name = "chkResetBindingSource";
            this.chkResetBindingSource.Size = new System.Drawing.Size(126, 17);
            this.chkResetBindingSource.TabIndex = 5;
            this.chkResetBindingSource.Text = "Reset BindingSource";
            this.chkResetBindingSource.UseVisualStyleBackColor = true;
            // 
            // chkShowDGWScroll
            // 
            this.chkShowDGWScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowDGWScroll.AutoSize = true;
            this.chkShowDGWScroll.Checked = true;
            this.chkShowDGWScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDGWScroll.Location = new System.Drawing.Point(140, 472);
            this.chkShowDGWScroll.Name = "chkShowDGWScroll";
            this.chkShowDGWScroll.Size = new System.Drawing.Size(98, 17);
            this.chkShowDGWScroll.TabIndex = 6;
            this.chkShowDGWScroll.Text = "DGW ScrollBar";
            this.chkShowDGWScroll.UseVisualStyleBackColor = true;
            this.chkShowDGWScroll.CheckedChanged += new System.EventHandler(this.chkShowDGWScroll_CheckedChanged);
            // 
            // DataGridView3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 569);
            this.Controls.Add(this.chkShowDGWScroll);
            this.Controls.Add(this.chkResetBindingSource);
            this.Controls.Add(this.chkAddSendData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnCreateColumns);
            this.Controls.Add(this.chkColumnsVisible);
            this.Controls.Add(this.panel1);
            this.Name = "DataGridView3";
            this.Text = "DataGridView3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkColumnsVisible;
        private System.Windows.Forms.Button btnCreateColumns;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkAddSendData;
        private System.Windows.Forms.CheckBox chkResetBindingSource;
        private System.Windows.Forms.CheckBox chkShowDGWScroll;
    }
}
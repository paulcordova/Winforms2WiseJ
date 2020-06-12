namespace Windows2Wisej
{
    partial class DataGridView
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
            this.panelCommands = new System.Windows.Forms.Panel();
            this.panelDatagrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddColumns = new System.Windows.Forms.Button();
            this.btnAddRows = new System.Windows.Forms.Button();
            this.btnClearColumns = new System.Windows.Forms.Button();
            this.btnClearRows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCommands.SuspendLayout();
            this.panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.label5);
            this.panelCommands.Controls.Add(this.label4);
            this.panelCommands.Controls.Add(this.label3);
            this.panelCommands.Controls.Add(this.label2);
            this.panelCommands.Controls.Add(this.label1);
            this.panelCommands.Controls.Add(this.btnClearRows);
            this.panelCommands.Controls.Add(this.btnClearColumns);
            this.panelCommands.Controls.Add(this.btnAddRows);
            this.panelCommands.Controls.Add(this.btnAddColumns);
            this.panelCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommands.Location = new System.Drawing.Point(0, 414);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(790, 75);
            this.panelCommands.TabIndex = 0;
            // 
            // panelDatagrid
            // 
            this.panelDatagrid.Controls.Add(this.dataGridView1);
            this.panelDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatagrid.Location = new System.Drawing.Point(0, 0);
            this.panelDatagrid.Name = "panelDatagrid";
            this.panelDatagrid.Size = new System.Drawing.Size(790, 414);
            this.panelDatagrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddColumns
            // 
            this.btnAddColumns.Location = new System.Drawing.Point(27, 6);
            this.btnAddColumns.Name = "btnAddColumns";
            this.btnAddColumns.Size = new System.Drawing.Size(145, 23);
            this.btnAddColumns.TabIndex = 2;
            this.btnAddColumns.Text = "Add &Columns";
            this.btnAddColumns.UseVisualStyleBackColor = true;
            this.btnAddColumns.Click += new System.EventHandler(this.btnAddColumns_Click);
            // 
            // btnAddRows
            // 
            this.btnAddRows.Location = new System.Drawing.Point(178, 6);
            this.btnAddRows.Name = "btnAddRows";
            this.btnAddRows.Size = new System.Drawing.Size(145, 23);
            this.btnAddRows.TabIndex = 3;
            this.btnAddRows.Text = "Add &Rows";
            this.btnAddRows.UseVisualStyleBackColor = true;
            this.btnAddRows.Click += new System.EventHandler(this.btnAddRows_Click);
            // 
            // btnClearColumns
            // 
            this.btnClearColumns.Location = new System.Drawing.Point(27, 35);
            this.btnClearColumns.Name = "btnClearColumns";
            this.btnClearColumns.Size = new System.Drawing.Size(145, 23);
            this.btnClearColumns.TabIndex = 4;
            this.btnClearColumns.Text = "Clear C&olumns";
            this.btnClearColumns.UseVisualStyleBackColor = true;
            this.btnClearColumns.Click += new System.EventHandler(this.btnClearColumns_Click);
            // 
            // btnClearRows
            // 
            this.btnClearRows.Location = new System.Drawing.Point(178, 35);
            this.btnClearRows.Name = "btnClearRows";
            this.btnClearRows.Size = new System.Drawing.Size(145, 23);
            this.btnClearRows.TabIndex = 5;
            this.btnClearRows.Text = "Clear R&ows";
            this.btnClearRows.UseVisualStyleBackColor = true;
            this.btnClearRows.Click += new System.EventHandler(this.btnClearRows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columns HeaderText ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 489);
            this.Controls.Add(this.panelDatagrid);
            this.Controls.Add(this.panelCommands);
            this.Name = "DataGridView";
            this.Text = "DataGridView";
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            this.panelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.Button btnClearRows;
        private System.Windows.Forms.Button btnClearColumns;
        private System.Windows.Forms.Button btnAddRows;
        private System.Windows.Forms.Button btnAddColumns;
        private System.Windows.Forms.Panel panelDatagrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
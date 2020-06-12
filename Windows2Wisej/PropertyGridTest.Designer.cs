namespace Windows2Wisej
{
    partial class PropertyGridTest
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
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.prpG = new System.Windows.Forms.PropertyGrid();
            this.pnlCommands.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.btnTest1);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommands.Location = new System.Drawing.Point(0, 0);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(440, 100);
            this.pnlCommands.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.prpG);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 100);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(440, 290);
            this.pnlControls.TabIndex = 1;
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(12, 36);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.Text = "Test &1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // prpG
            // 
            this.prpG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prpG.Location = new System.Drawing.Point(0, 0);
            this.prpG.Name = "prpG";
            this.prpG.Size = new System.Drawing.Size(440, 290);
            this.prpG.TabIndex = 0;
            // 
            // PropertyGridTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 390);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlCommands);
            this.Name = "PropertyGridTest";
            this.Text = "PropertyGridTest";
            this.pnlCommands.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PropertyGrid prpG;
    }
}
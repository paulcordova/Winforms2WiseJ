namespace Windows2Wisej
{
    partial class ComboBoxTest2
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Simple = new System.Windows.Forms.Button();
            this.AddItems = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(31, 24);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(220, 137);
            this.comboBox.TabIndex = 0;
            // 
            // Simple
            // 
            this.Simple.Location = new System.Drawing.Point(257, 24);
            this.Simple.Name = "Simple";
            this.Simple.Size = new System.Drawing.Size(86, 35);
            this.Simple.TabIndex = 1;
            this.Simple.Text = "Simple";
            this.Simple.UseVisualStyleBackColor = true;
            this.Simple.Click += new System.EventHandler(this.Simple_Click);
            // 
            // AddItems
            // 
            this.AddItems.Location = new System.Drawing.Point(367, 26);
            this.AddItems.Name = "AddItems";
            this.AddItems.Size = new System.Drawing.Size(93, 33);
            this.AddItems.TabIndex = 2;
            this.AddItems.Text = "Add Items";
            this.AddItems.UseVisualStyleBackColor = true;
            this.AddItems.Click += new System.EventHandler(this.AddItems_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(367, 65);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(93, 33);
            this.Clean.TabIndex = 3;
            this.Clean.Text = "Clean Items";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 244);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.AddItems);
            this.Controls.Add(this.Simple);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private int last_item = 0;

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button Simple;
        private System.Windows.Forms.Button AddItems;
        private System.Windows.Forms.Button Clean;
    }
}


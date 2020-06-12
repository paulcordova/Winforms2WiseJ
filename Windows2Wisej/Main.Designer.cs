namespace Windows2Wisej
{
    partial class Main
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
            this.button17 = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(439, 84);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(159, 42);
            this.button17.TabIndex = 0;
            this.button17.Text = "ListViewVirtualMode";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // ListBox
            // 
            this.ListBox.Location = new System.Drawing.Point(439, 35);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(159, 43);
            this.ListBox.TabIndex = 2;
            this.ListBox.Text = "ListBox";
            this.ListBox.UseVisualStyleBackColor = true;
            this.ListBox.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "ComboBoxTest2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(41, 243);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 43);
            this.button10.TabIndex = 4;
            this.button10.Text = "CheckedListBox";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 534);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.button17);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button ListBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
    }
}
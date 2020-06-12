namespace Windows2Wisej
{
    partial class PopUp
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
            this.btnBell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBell
            // 
            this.btnBell.Location = new System.Drawing.Point(44, 47);
            this.btnBell.Name = "btnBell";
            this.btnBell.Size = new System.Drawing.Size(123, 52);
            this.btnBell.TabIndex = 0;
            this.btnBell.Text = "PopUp";
            this.btnBell.UseVisualStyleBackColor = true;
            this.btnBell.Click += new System.EventHandler(this.btnBell_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 356);
            this.Controls.Add(this.btnBell);
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBell;
    }
}
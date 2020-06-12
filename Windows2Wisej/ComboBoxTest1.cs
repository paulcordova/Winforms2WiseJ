using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows2Wisej
{
    public partial class ComboBoxTest1 : Form
    {

        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox15;
        private ComboBox comboBox14;
        private ComboBox comboBox17;
        private ComboBox comboBox16;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox13;
        private ComboBox comboBox12;


        public ComboBoxTest1()
        {
            this.comboBox12 = new ComboBox();
            this.comboBox13 = new ComboBox();
            this.comboBox10 = new ComboBox();
            this.comboBox11 = new ComboBox();
            this.comboBox16 = new ComboBox();
            this.comboBox17 = new ComboBox();
            this.comboBox14 = new ComboBox();
            this.comboBox15 = new ComboBox();
            this.comboBox3 = new ComboBox();
            this.comboBox2 = new ComboBox();
            this.comboBox7 = new ComboBox();
            this.comboBox6 = new ComboBox();
            this.comboBox5 = new ComboBox();
            this.comboBox4 = new ComboBox();
            this.comboBox = new ComboBox();
            this.comboBox9 = new ComboBox();
            this.comboBox8 = new ComboBox();

            InitializeComponent();

            InitComboBoxes();

        }

        private void InitComboBoxes()
        {
            // 
            // comboBox12
            // 
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBox12.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox12.Location = new System.Drawing.Point(288, 112);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(248, 22);
            this.comboBox12.TabIndex = 12;
            this.comboBox12.Text = "A normal ComboBox - Font.Italic=True";
            // 
            // comboBox13
            // 
            this.comboBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.comboBox13.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox13.Location = new System.Drawing.Point(288, 144);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(248, 22);
            this.comboBox13.TabIndex = 13;
            this.comboBox13.Text = "A normal ComboBox - Font.Strikeout=True";
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox10.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox10.Location = new System.Drawing.Point(288, 48);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(248, 22);
            this.comboBox10.TabIndex = 9;
            // 
            // comboBox11
            // 
            this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox11.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox11.Location = new System.Drawing.Point(288, 80);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(248, 22);
            this.comboBox11.TabIndex = 11;
            this.comboBox11.Text = "A normal ComboBox - Font.Bold=True";
            // 
            // comboBox16
            // 
            this.comboBox16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox16.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox16.Location = new System.Drawing.Point(288, 240);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(320, 23);
            this.comboBox16.TabIndex = 16;
            this.comboBox16.Text = "A normal ComboBox - Font=Verdana; 9,75pt";
            // 
            // comboBox17
            // 
            this.comboBox17.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.comboBox17.AutoSize = false;
            this.comboBox17.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox17.Location = new System.Drawing.Point(8, 256);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(248, 21);
            this.comboBox17.TabIndex = 19;
            this.comboBox17.Text = "A normal ComboBox - Anchor=All";
            // 
            // comboBox14
            // 
            this.comboBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.comboBox14.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox14.Location = new System.Drawing.Point(288, 176);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(248, 22);
            this.comboBox14.TabIndex = 14;
            this.comboBox14.Text = "A normal ComboBox - Font.Underline=True";
            // 
            // comboBox15
            // 
            this.comboBox15.ForeColor = System.Drawing.Color.Red;
            this.comboBox15.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox15.Location = new System.Drawing.Point(288, 208);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(248, 22);
            this.comboBox15.TabIndex = 15;
            this.comboBox15.Text = "A normal ComboBox - Font.ForeColor=Red";
            // 
            // comboBox3
            // 
            this.comboBox3.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox3.Location = new System.Drawing.Point(8, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(248, 22);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "A normal ComboBox - MaxDropDownItems=2";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox2.Location = new System.Drawing.Point(8, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 22);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "A normal ComboBox - Enabled=False";
            // 
            // comboBox7
            // 
            this.comboBox7.AutoSize = false;
            this.comboBox7.Dock = DockStyle.Bottom;
            this.comboBox7.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox7.Location = new System.Drawing.Point(0, 288);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(624, 21);
            this.comboBox7.TabIndex = 6;
            this.comboBox7.Text = "A normal ComboBox";
            // 
            // comboBox6
            // 
            this.comboBox6.AutoSize = false;
            this.comboBox6.Dock = DockStyle.Top;
            this.comboBox6.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox6.Location = new System.Drawing.Point(0, 0);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(624, 21);
            this.comboBox6.TabIndex = 5;
            this.comboBox6.Text = "A normal ComboBox";
            // 
            // comboBox5
            // 
            this.comboBox5.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox5.Location = new System.Drawing.Point(8, 160);
            this.comboBox5.MaxLength = 5;
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(248, 22);
            this.comboBox5.TabIndex = 4;
            this.comboBox5.Text = "A normal ComboBox - MaxLength=5";
            // 
            // comboBox4
            // 
            this.comboBox4.Items.AddRange(new object[] {
            "http://sourceforge.net/projects/luckyhands",
            "http://www.go-mono.com",
            "http://www.got-mono.com"});
            this.comboBox4.Location = new System.Drawing.Point(8, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(248, 22);
            this.comboBox4.Sorted = true;
            this.comboBox4.TabIndex = 3;
            this.comboBox4.Text = "A normal ComboBox - Sorted=True";
            // 
            // comboBox
            // 
            this.comboBox.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox.Location = new System.Drawing.Point(8, 32);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(248, 22);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "A normal ComboBox";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = ComboBoxStyle.Simple;
            this.comboBox9.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox9.Location = new System.Drawing.Point(8, 224);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(248, 21);
            this.comboBox9.TabIndex = 8;
            this.comboBox9.Text = "A normal ComboBox - DropDownStyle=Simple";
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.Red;
            this.comboBox8.Items.AddRange(new object[] {
            "http://www.go-mono.com",
            "http://www.got-mono.com",
            "http://sourceforge.net/projects/luckyhands"});
            this.comboBox8.Location = new System.Drawing.Point(8, 192);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(248, 22);
            this.comboBox8.TabIndex = 7;
            this.comboBox8.Text = "A normal ComboBox - BackColor=Red";
            // 
            // ComboBoxTest1
            // 
            this.ClientSize = new System.Drawing.Size(624, 309);
            this.Controls.Add(this.comboBox17);
            this.Controls.Add(this.comboBox16);
            this.Controls.Add(this.comboBox15);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox);
            this.Name = "ComboBoxTest1";
            this.Text = "ComboBoxTest1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace HTMLtoEXE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WtE is a program that converts Websites (HTML. CSS, JS) to EXEs (Electron Webapps" +
    ")";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find ZIP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "locate your ZIP that contains the Website and its Contents (HTML, CSS, JS, Resour" +
    "ces)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "ZIP Files|*.zip";
            this.openFileDialog1.Title = "Find a ZIP File with an HTML site in it!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Once you have seen the Message Box and extracted your site into my program, Fill " +
    "in the data below:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "projectName";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1.0.0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "authorName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Build";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dont have Node.js installed?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(552, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Download it from Nodejs.org";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Have Node but no Electron?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Install Electron Builder with Node.js";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(117, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "WARNING! You need Electron Builder First! ->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "You can leave it all default if you dont care";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "1000";
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(264, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "800";
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Length X height in PX (Window Width and Height)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HTML to EXE (Requires Internet and Node.js)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
    }
}


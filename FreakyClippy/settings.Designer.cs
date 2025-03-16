namespace FreakyClippy
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            numericUpDown4 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            numericUpDown5 = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            numericUpDown6 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 0;
            label1.Text = "Animation time between frames (ms)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 27);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(70, 88);
            numericUpDown2.Maximum = new decimal(new int[] { 7200, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(44, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 2;
            label2.Text = "Random time between talking (s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Between";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 5;
            label4.Text = "and";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(70, 117);
            numericUpDown3.Maximum = new decimal(new int[] { 14400, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 75, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(44, 23);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "syntaxglow.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 156);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 9;
            button2.Text = "Load default";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 185);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(441, 177);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(369, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 17);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(312, 62);
            numericUpDown4.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(44, 23);
            numericUpDown4.TabIndex = 17;
            numericUpDown4.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 66);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 16;
            label6.Text = "Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 35);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 15;
            label7.Text = "X";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(312, 33);
            numericUpDown5.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(44, 23);
            numericUpDown5.TabIndex = 14;
            numericUpDown5.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(292, 9);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 13;
            label8.Text = "Speech bubble size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(292, 96);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 18;
            label9.Text = "Min. font size";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(292, 114);
            numericUpDown6.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown6.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(44, 23);
            numericUpDown6.TabIndex = 20;
            numericUpDown6.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 392);
            Controls.Add(numericUpDown6);
            Controls.Add(label9);
            Controls.Add(numericUpDown4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(numericUpDown5);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(numericUpDown3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "settings";
            Text = "FreakyClippy Settings & About";
            TopMost = true;
            Load += settings_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown4;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown5;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown6;
    }
}
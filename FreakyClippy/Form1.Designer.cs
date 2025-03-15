namespace FreakyClippy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            clippyPictureBox = new PictureBox();
            ContextMenuStripSettings = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            RandomBubbleTimer = new System.Windows.Forms.Timer(components);
            AnimationTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)clippyPictureBox).BeginInit();
            ContextMenuStripSettings.SuspendLayout();
            SuspendLayout();
            // 
            // clippyPictureBox
            // 
            clippyPictureBox.Image = (Image)resources.GetObject("clippyPictureBox.Image");
            clippyPictureBox.Location = new Point(12, 326);
            clippyPictureBox.Name = "clippyPictureBox";
            clippyPictureBox.Size = new Size(124, 93);
            clippyPictureBox.TabIndex = 0;
            clippyPictureBox.TabStop = false;
            clippyPictureBox.MouseDown += pictureBox1_MouseDown;
            clippyPictureBox.MouseMove += pictureBox1_MouseMove;
            clippyPictureBox.MouseUp += pictureBox1_MouseUp;
            // 
            // ContextMenuStripSettings
            // 
            ContextMenuStripSettings.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, closeToolStripMenuItem });
            ContextMenuStripSettings.Name = "contextMenuStripSettings";
            ContextMenuStripSettings.Size = new Size(181, 70);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Exit";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // RandomBubbleTimer
            // 
            RandomBubbleTimer.Tick += RandomBubbleTimer_Tick;
            // 
            // AnimationTimer
            // 
            AnimationTimer.Interval = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 431);
            Controls.Add(clippyPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            TransparencyKey = SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)clippyPictureBox).EndInit();
            ContextMenuStripSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox clippyPictureBox;
        private ContextMenuStrip ContextMenuStripSettings;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer RandomBubbleTimer;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}

using System;
using FreakyClippy.Properties;

namespace FreakyClippy
{
    public partial class Form1 : Form
    {
        private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private bool isDragging = false;
        private Point offset;
        string selectedAnimation = "writing";
        private int animationNo = 0;
        private Panel speechBubble;
        private Label speechText;
        private List<string> clippyLines = new List<string>();
        private Random random = new Random();
        private List<string> animationDirectories;
        //Settings
        private int minMsBetweenLines = Properties.Settings.Default.minSeconds * 1000;
        private int maxMsBetweenLines = Properties.Settings.Default.maxSeconds * 1000;
        private int msBetweenFrames = Properties.Settings.Default.timeBetweenFrames;
        private int speechBubbleSizeX = Properties.Settings.Default.speechBubbleX;
        private int speechBubbleSizeY = Properties.Settings.Default.speechBubbleY;
        private int minSpeechBubbleFontSize = Properties.Settings.Default.minFontSize;


        public Form1()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            // Create panel (bubble)
            speechBubble = new Panel
            {
                Size = new Size(speechBubbleSizeX, speechBubbleSizeY),
                BackColor = Color.LightYellow,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            // Create label for speech text
            speechText = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            speechBubble.Controls.Add(speechText);
            this.Controls.Add(speechBubble);
            LoadClippyLines();
            animationDirectories = GetAnimationDirectories();
            RandomBubbleTimer.Start();
        }

        private List<string> GetAnimationDirectories()
        {
            string animationsPath = Path.Combine(appDirectory, "animations");

            try
            {
                // Get all subdirectories (animation folders) inside the "animations" folder
                return Directory.GetDirectories(animationsPath).Select(Path.GetFileName).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading animation directories: " + ex.Message, "CLIPPY MADE A F*CKY-WUCKY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        private void ShowRandomClippyLine()
        {
            if (clippyLines.Count > 0)
            {
                Random random = new Random();
                string randomLine = clippyLines[random.Next(clippyLines.Count)];

                string selectedAnimation = animationDirectories[random.Next(animationDirectories.Count)];

                ShowSpeechBubble(randomLine, 10000);

                selectedAnimation = animationDirectories[random.Next(0, animationDirectories.Count)];
                PlayRandomAnimation(selectedAnimation);
            }
        }

        private void PlayRandomAnimation(string animation)
        {
            animationNo = 0;  // Reset to the first frame of the animation.

            string animationPath = Path.Combine(appDirectory, "animations", animation);
            int totalFrames = CountFilesInDirectory(animationPath); // Get total number of frames in the animation.

            if (totalFrames > 0)
            {
                // Create a new timer for each animation.
                System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer
                {
                    Interval = msBetweenFrames // Set interval between frames (200ms).
                };

                // Subscribe to the Tick event of the new timer.
                animationTimer.Tick += (sender, e) =>
                {
                    try
                    {
                        string frameFile = Path.Combine(animationPath, animationNo.ToString() + ".png");
                        clippyPictureBox.Image = Image.FromFile(frameFile);
                        animationNo++;

                        if (animationNo >= totalFrames) // If all frames are played, stop the timer.
                        {
                            clippyPictureBox.Image = Image.FromFile(Path.Combine(appDirectory, "animations", "default.png")); // Default image.
                            animationTimer.Stop();  // Stop the timer once the animation finishes.
                            animationTimer.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error playing animation: " + ex.Message, "CLIPPY MADE A F*CKY-WUCKY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clippyPictureBox.Image = Image.FromFile(Path.Combine(appDirectory, "animations", "default.png"));
                        animationTimer.Stop();  // Stop the timer in case of an error.
                        animationTimer.Dispose();
                    }
                };
                animationTimer.Start();
            }
        }

        private void AdjustFontSizeToFitPanel(string text, Panel panel, Label label)
        {
            int fontSize = 20;
            int minFontSize = minSpeechBubbleFontSize;
            Font font = new Font("Arial", fontSize);
            SizeF textSize = GetTextSize(text, font);

            // Reduce font size until text fits or it reaches the minimum font size
            while ((textSize.Width > panel.Width || textSize.Height > panel.Height) && fontSize > minFontSize)
            {
                fontSize--;
                font = new Font("Arial", fontSize);
                textSize = GetTextSize(text, font);
            }

            label.Font = font;
        }

        private SizeF GetTextSize(string text, Font font)
        {
            using (Graphics g = this.CreateGraphics())
            {
                return g.MeasureString(text, font);
            }
        }

        private void LoadClippyLines()
        {
            string filePath = Path.Combine(appDirectory, "lines.txt");

            try
            {
                if (File.Exists(filePath))
                {
                    clippyLines = File.ReadAllLines(filePath).ToList();
                }
                else
                {
                    MessageBox.Show("Error: lines.txt not found!", "CLIPPY MADE A F*CKY-WUCKY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lines: " + ex.Message, "CLIPPY MADE A F*CKY-WUCKY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSpeechBubble(string text, int duration)
        {
            speechText.Text = text;

            AdjustFontSizeToFitPanel(text, speechBubble, speechText);

            // Position the speech bubble above Clippy
            speechBubble.Location = new Point(clippyPictureBox.Left, clippyPictureBox.Top - speechBubble.Height - 10);
            speechBubble.Visible = true;

            // Hide after duration
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                speechBubble.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = new Point(clippyPictureBox.Location.X + e.X, clippyPictureBox.Location.Y + e.Y);
            }
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStripSettings.Show(Form1.MousePosition);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Move form while keeping the relative offset
                this.Location = new Point(Cursor.Position.X - offset.X, Cursor.Position.Y - offset.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        public int CountFilesInDirectory(string directoryPath)
        {
            return Directory.GetFiles(directoryPath).Length;
        }

        /*
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAnimation))
            {
                try
                {
                    clippyPictureBox.Image = Image.FromFile(appDirectory + "\\animations\\" + selectedAnimation + "\\" + animationNo.ToString() + ".png");
                    animationNo++;
                    if (animationNo >= CountFilesInDirectory(appDirectory + "\\animations\\" + selectedAnimation))
                    {
                        clippyPictureBox.Image = Image.FromFile(appDirectory + "\\animations\\default.png");
                        animationNo = 0;
                        AnimationTimer.Stop();
                    }

                }
                catch
                {

                }
            }
        }

        */

        private void animateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void RandomBubbleTimer_Tick(object sender, EventArgs e)
        {
            ShowRandomClippyLine();
            RandomBubbleTimer.Interval = random.Next(minMsBetweenLines, maxMsBetweenLines);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings();
            settingsForm.ShowDialog();

            Application.Restart();
            Environment.Exit(0);
        }
    }
}

namespace String_Reverser_Word_Stacks_GUI
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
            ReverseButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            JokeTextBox = new TextBox();
            getJokesButton = new Button();
            ReversedJokesFromFileLabel = new Label();
            ReversedJokeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // ReverseButton
            // 
            ReverseButton.Location = new Point(32, 150);
            ReverseButton.Name = "ReverseButton";
            ReverseButton.Size = new Size(189, 29);
            ReverseButton.TabIndex = 0;
            ReverseButton.Text = "Reverse Joke";
            ReverseButton.UseVisualStyleBackColor = true;
            ReverseButton.Click += ReverseButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Chuck Norris Joke:";
            // 
            // JokeTextBox
            // 
            JokeTextBox.Location = new Point(32, 59);
            JokeTextBox.Multiline = true;
            JokeTextBox.Name = "JokeTextBox";
            JokeTextBox.Size = new Size(716, 27);
            JokeTextBox.TabIndex = 3;
            // 
            // getJokesButton
            // 
            getJokesButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            getJokesButton.Location = new Point(32, 209);
            getJokesButton.Name = "getJokesButton";
            getJokesButton.Size = new Size(201, 29);
            getJokesButton.TabIndex = 4;
            getJokesButton.Text = "Get Reveresed Jokes";
            getJokesButton.UseVisualStyleBackColor = true;
            getJokesButton.Click += getJokesButton_Click;
            // 
            // ReversedJokesFromFileLabel
            // 
            ReversedJokesFromFileLabel.AutoSize = true;
            ReversedJokesFromFileLabel.Location = new Point(32, 261);
            ReversedJokesFromFileLabel.Name = "ReversedJokesFromFileLabel";
            ReversedJokesFromFileLabel.Size = new Size(73, 20);
            ReversedJokesFromFileLabel.TabIndex = 5;
            ReversedJokesFromFileLabel.Text = "cfvghbjnk";
            // 
            // ReversedJokeLabel
            // 
            ReversedJokeLabel.AutoSize = true;
            ReversedJokeLabel.Location = new Point(32, 101);
            ReversedJokeLabel.Name = "ReversedJokeLabel";
            ReversedJokeLabel.Size = new Size(0, 20);
            ReversedJokeLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(ReversedJokeLabel);
            Controls.Add(ReversedJokesFromFileLabel);
            Controls.Add(getJokesButton);
            Controls.Add(JokeTextBox);
            Controls.Add(label1);
            Controls.Add(ReverseButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReverseButton;
        private FileSystemWatcher fileSystemWatcher1;
        private Label ReversedJokesFromFileLabel;
        private Button getJokesButton;
        private TextBox JokeTextBox;
        private Label label1;
        private Label ReversedJokeLabel;
    }
}
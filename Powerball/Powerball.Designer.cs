namespace Powerball
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            enterButton = new Button();
            textBox6 = new TextBox();
            label3 = new Label();
            resultMessage = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(76, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(573, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(76, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 96);
            label2.Name = "label2";
            label2.Size = new Size(254, 20);
            label2.TabIndex = 5;
            label2.Text = "Input your Powerball numbers below.";
            // 
            // enterButton
            // 
            enterButton.Location = new Point(352, 290);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(94, 29);
            enterButton.TabIndex = 6;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(712, 192);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(76, 27);
            textBox6.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(712, 152);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Powerball";
            // 
            // resultMessage
            // 
            resultMessage.AutoSize = true;
            resultMessage.Location = new Point(383, 390);
            resultMessage.Name = "resultMessage";
            resultMessage.Size = new Size(0, 20);
            resultMessage.TabIndex = 9;
            resultMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultMessage);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(enterButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Button enterButton;
        private TextBox textBox6;
        private Label label3;
        private Label resultMessage;
    }
}
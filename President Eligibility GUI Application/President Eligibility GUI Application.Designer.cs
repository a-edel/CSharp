namespace President_Eligibility_GUI_Application
{
    partial class presidentEligibilityForm
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
            birthYearLabel = new Label();
            yearsResidedLabel = new Label();
            priorTermsServedLabel = new Label();
            birthYearTextBox = new TextBox();
            yearsResidedTextBox = new TextBox();
            priorTermsServedTextBox = new TextBox();
            naturalBornCitizenCheckbox = new CheckBox();
            rebelledCheckBox = new CheckBox();
            determineEligibilityButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new Point(274, 113);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new Size(165, 20);
            birthYearLabel.TabIndex = 0;
            birthYearLabel.Text = "What is your birth year?";            
            // 
            // yearsResidedLabel
            // 
            yearsResidedLabel.AutoSize = true;
            yearsResidedLabel.Location = new Point(65, 181);
            yearsResidedLabel.Name = "yearsResidedLabel";
            yearsResidedLabel.Size = new Size(374, 20);
            yearsResidedLabel.TabIndex = 1;
            yearsResidedLabel.Text = "How many years have you resided in the United States?";            
            // 
            // priorTermsServedLabel
            // 
            priorTermsServedLabel.AutoSize = true;
            priorTermsServedLabel.Location = new Point(165, 252);
            priorTermsServedLabel.Name = "priorTermsServedLabel";
            priorTermsServedLabel.Size = new Size(274, 20);
            priorTermsServedLabel.TabIndex = 2;
            priorTermsServedLabel.Text = "How many prior terms have you served?";
            // 
            // birthYearTextBox
            // 
            birthYearTextBox.Location = new Point(455, 110);
            birthYearTextBox.Name = "birthYearTextBox";
            birthYearTextBox.Size = new Size(125, 27);
            birthYearTextBox.TabIndex = 3;
            // 
            // yearsResidedTextBox
            // 
            yearsResidedTextBox.Location = new Point(455, 178);
            yearsResidedTextBox.Name = "yearsResidedTextBox";
            yearsResidedTextBox.Size = new Size(125, 27);
            yearsResidedTextBox.TabIndex = 4;
            // 
            // priorTermsServedTextBox
            // 
            priorTermsServedTextBox.Location = new Point(455, 249);
            priorTermsServedTextBox.Name = "priorTermsServedTextBox";
            priorTermsServedTextBox.Size = new Size(125, 27);
            priorTermsServedTextBox.TabIndex = 5;
            // 
            // naturalBornCitizenCheckbox
            // 
            naturalBornCitizenCheckbox.AutoSize = true;
            naturalBornCitizenCheckbox.Location = new Point(366, 45);
            naturalBornCitizenCheckbox.Name = "naturalBornCitizenCheckbox";
            naturalBornCitizenCheckbox.Size = new Size(164, 24);
            naturalBornCitizenCheckbox.TabIndex = 6;
            naturalBornCitizenCheckbox.Text = "Natural Born Citizen";
            naturalBornCitizenCheckbox.UseVisualStyleBackColor = true;
            naturalBornCitizenCheckbox.CheckedChanged += naturalBornCitizenCheckBox_CheckedChanged;
            // 
            // rebelledCheckBox
            // 
            rebelledCheckBox.AutoSize = true;
            rebelledCheckBox.Location = new Point(305, 318);
            rebelledCheckBox.Name = "rebelledCheckBox";
            rebelledCheckBox.Size = new Size(298, 24);
            rebelledCheckBox.TabIndex = 7;
            rebelledCheckBox.Text = "I have rebelled against the United States";
            rebelledCheckBox.UseVisualStyleBackColor = true;
            rebelledCheckBox.CheckedChanged += rebelledCheckBox_CheckedChanged;
            // 
            // determineEligibilityButton
            // 
            determineEligibilityButton.Location = new Point(399, 398);
            determineEligibilityButton.Name = "determineEligibilityButton";
            determineEligibilityButton.Size = new Size(94, 57);
            determineEligibilityButton.TabIndex = 8;
            determineEligibilityButton.Text = "Determine Eligibility";
            determineEligibilityButton.UseVisualStyleBackColor = true;
            determineEligibilityButton.Click += determineEligibilityButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // presidentEligibilityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 500);
            Controls.Add(determineEligibilityButton);
            Controls.Add(rebelledCheckBox);
            Controls.Add(naturalBornCitizenCheckbox);
            Controls.Add(priorTermsServedTextBox);
            Controls.Add(yearsResidedTextBox);
            Controls.Add(birthYearTextBox);
            Controls.Add(priorTermsServedLabel);
            Controls.Add(yearsResidedLabel);
            Controls.Add(birthYearLabel);
            Name = "presidentEligibilityForm";
            Text = "President Eligibility Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label birthYearLabel;
        private Label yearsResidedLabel;
        private Label priorTermsServedLabel;
        private TextBox birthYearTextBox;
        private TextBox yearsResidedTextBox;
        private TextBox priorTermsServedTextBox;
        private CheckBox naturalBornCitizenCheckbox;
        private CheckBox rebelledCheckBox;
        private Button determineEligibilityButton;
        private ContextMenuStrip contextMenuStrip1;
    }
}
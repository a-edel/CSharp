namespace President_Eligibility_GUI_Application
{
    public partial class presidentEligibilityForm : Form
    {
        public presidentEligibilityForm()
        {
            InitializeComponent();
        }

        private void naturalBornCitizenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }        

        private void rebelledCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void determineEligibilityButton_Click(object sender, EventArgs e)
        {
            bool isCitizen = naturalBornCitizenCheckbox.Checked;

            int currentYear = DateTime.Now.Year;
            String birthYear = birthYearTextBox.Text;
            bool isAtLeast35 = currentYear - int.Parse(birthYear) >= 35;

            String residentYears = yearsResidedTextBox.Text;
            bool isResidentFor14Years = int.Parse(residentYears) >= 14;

            String priorTermsServed = priorTermsServedTextBox.Text;
            bool servedLessThanTwoTerms = int.Parse(priorTermsServed) < 2;

            bool hasNotRebelled = !rebelledCheckBox.Checked;

            if (isCitizen && isAtLeast35 && isResidentFor14Years && servedLessThanTwoTerms && hasNotRebelled)
            {
                determineEligibilityButton.BackColor = Color.Green;
                determineEligibilityButton.Text = "ELIGIBLE";
            }
            else
            {
                determineEligibilityButton.BackColor = Color.Red;
                determineEligibilityButton.Text = "NOT ELIGIBLE";
            }
        }
    }
}
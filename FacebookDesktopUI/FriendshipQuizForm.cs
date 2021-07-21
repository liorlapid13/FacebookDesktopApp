using System;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class FriendshipQuizForm : Form
    {
        private const string k_FailedToRetrieveUserInformationError =
            "Failed to retrieve user information, please try again";

        private readonly Friendships r_Friendships;

        public FriendshipQuizForm(Friendships i_Friendships)
        {
            r_Friendships = i_Friendships;
            InitializeComponent();
            personalizeFriendshipQuizForm();
        }

        private void personalizeFriendshipQuizForm()
        {
            try
            {
                new Thread(setQuizAnswers).Start();
                string friendFirstName = r_Friendships.GetFriendFirstName();

                answerQuestionsLabel.Text = string.Format(
                    "Answer the following questions about {0}",
                    friendFirstName);
                birthdayLabel.Text = string.Format("When was {0} born? (mm/dd/yyyy)", friendFirstName);
                cityLabel.Text = string.Format("In which city does {0} live?", friendFirstName);
                countryLabel.Text = string.Format("In which country does {0} live?", friendFirstName);
                relationshipStatusLabel.Text = string.Format("What is {0}'s relationship status?", friendFirstName);
                religionLabel.Text = string.Format("What is {0}'s religion?", friendFirstName);
            }
            catch(Exception exception)
            {
                MessageBox.Show(k_FailedToRetrieveUserInformationError);
            }
        }

        private void setQuizAnswers()
        {
            setBirthdayAnswer();
            setCityAnswer();
            setCountryAnswer();
            setRelationshipStatusAnswer();
            setReligionAnswer();
        }

        private void setBirthdayAnswer()
        {
            try
            {
                string birthday = r_Friendships.GetFriendBirthday();

                birthdayAnswerTextBox.Invoke(new Action(() => birthdayAnswerTextBox.Text = birthday));
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: Failed to fetch friend's birthday, please try again");
            }
        }

        private void setCityAnswer()
        {
            try
            {
                string city = r_Friendships.GetFriendCity();

                cityAnswerTextBox.Invoke(new Action(() => cityAnswerTextBox.Text = city));
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: Failed to fetch friend's city, please try again");
            }
        }

        private void setCountryAnswer()
        {
            try
            {
                string country = r_Friendships.GetFriendCountry();

                countryAnswerTextBox.Invoke(new Action(() => countryAnswerTextBox.Text = country));
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: Failed to fetch friend's country, please try again");
            }
        }

        private void setRelationshipStatusAnswer()
        {
            try
            {
                string relationshipStatus = r_Friendships.GetFriendRelationshipStatus();

                relationshipStatusAnswerTextBox.Invoke(
                    new Action(() => relationshipStatusAnswerTextBox.Text = relationshipStatus));
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: Failed to fetch friend's relationship status, please try again");
            }
        }

        private void setReligionAnswer()
        {
            try
            {
                string religion = r_Friendships.GetFriendReligion();

                religionAnswerTextBox.Invoke(new Action(() => religionAnswerTextBox.Text = religion));
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error: Failed to fetch friend's religion, please try again");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(checkIfAllQuestionsAnswered())
            {
                answersPanel.Visible = true;
                buttonSubmit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please answer all questions before submitting the form");
            }
        }

        private bool checkIfAllQuestionsAnswered()
        {
            return !string.IsNullOrEmpty(birthdayTextBox.Text) && !string.IsNullOrEmpty(cityTextBox.Text)
                                                               && !string.IsNullOrEmpty(countryTextBox.Text)
                                                               && relationshipStatusComboBox.SelectedIndex != -1
                                                               && religionComboBox.SelectedIndex != -1;
        }
    }
}
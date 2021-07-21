using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class MainForm : Form
    {
        private const string k_SuccessfulPostPublish = "Post published successfully";
        private const string k_EmptyPostPublishAttempt = "You cannot publish an empty post";
        private const string k_DefaultPostBoxText = "What's on your mind?";

        private readonly MainPage r_MainPage;
        private readonly LoginForm r_LoginForm;

        public MainForm(LoginForm i_LoginForm)
        {
            r_MainPage = new MainPage();
            InitializeComponent();
            r_LoginForm = i_LoginForm;
            r_LoginForm.Visible = false;
            personalizeFormToUser();
        }

        private void personalizeFormToUser()
        {
            new Thread(() =>
                {
                    try
                    {
                        profilePictureBox.ImageLocation = r_MainPage.GetProfilePicture();
                        personalizedWelcomeLabel.Text = string.Format("Hello {0}", r_MainPage.GetUserName());
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }).Start();
        }

        private void pagesButton_Click(object sender, EventArgs e)
        {
            try
            {
                pageBindingSource.DataSource = r_MainPage.GetPageList();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.DataSource = r_MainPage.GetFriendsList();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            try
            {
                groupBindingSource.DataSource = r_MainPage.GetGroupList();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_MainPage.Logout();
            r_LoginForm.Visible = true;
            Close();
        }

        private void postTextBox_Click(object sender, EventArgs e)
        {
            if(string.Equals(textBoxPost.Text, k_DefaultPostBoxText))
            {
                textBoxPost.Clear();
                buttonPost.Enabled = true;
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    if(!string.IsNullOrEmpty(textBoxPost.Text))
                    {
                        r_MainPage.PublishPost(textBoxPost.Text);
                        MessageBox.Show(k_SuccessfulPostPublish);
                    }
                    else
                    {
                        MessageBox.Show(k_EmptyPostPublishAttempt);
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    textBoxPost.Invoke(new Action(() => textBoxPost.Text = k_DefaultPostBoxText));
                    buttonPost.Invoke(new Action(() => buttonPost.Enabled = false));
                }
            }).Start();
        }

        private void buttonAdvancedFriendFilters_Click(object sender, EventArgs e)
        {
            new AdvancedFriendFiltersForm().ShowDialog();
        }

        private void buttonFriendships_Click(object sender, EventArgs e)
        {
            new FriendshipsForm().ShowDialog();
        }

        private void buttonViewPosts_Click(object sender, EventArgs e)
        {
            new MyPostsForm().ShowDialog();
        }
    }
}

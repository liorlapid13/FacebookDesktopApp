using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopUI
{
    public partial class FriendshipsForm : Form
    {
        private const string k_NoFriendSelectedError = "You must select a friend, please try again";

        private readonly Friendships r_Friendships;

        public FriendshipsForm()
        {
            r_Friendships = new Friendships();
            InitializeComponent();
            previewFriendsList();
            setProfilePicture();
        }

        private void setProfilePicture()
        {
            try
            {
                userProfilePicturePictureBox.LoadAsync(r_Friendships.GetProfilePicture());
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void previewFriendsList()
        {
            try
            {
                userBindingSource.DataSource = r_Friendships.GetFriendList();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonShowFriendship_Click(object sender, EventArgs e)
        {
            if(listBoxFriends.SelectedItem == null)
            {
                MessageBox.Show(k_NoFriendSelectedError);
            }
            else
            {
                try
                {
                    showFriendship(listBoxFriends.SelectedIndex);
                    buttonFriendshipQuiz.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void showFriendship(int i_SelectedFriendIndex)
        {
            r_Friendships.SetSelectedFriend(i_SelectedFriendIndex);
            new Thread(setFriendProfilePicture).Start();
            new Thread(showSharedCheckIns).Start();
            new Thread(showSharedLikedPages).Start();
            new Thread(showMutualFriends).Start();
            new Thread(showSharedEvents).Start();
        }

        private void setFriendProfilePicture()
        {
            try
            {
                string pictureURL = r_Friendships.GetFriendProfilePicture();

                friendProfilePicturePictureBox.Invoke(
                    new Action(() => friendProfilePicturePictureBox.LoadAsync(pictureURL)));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showSharedCheckIns()
        {
            try
            {
                FacebookObjectCollection<Checkin> sharedCheckins = r_Friendships.GetSharedCheckIns();

                listBoxCheckins.Invoke(new Action(() => checkinBindingSource.DataSource = sharedCheckins));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showSharedLikedPages()
        {
            try
            {
                FacebookObjectCollection<Page> sharedPages = r_Friendships.GetCommonLikedPages();

                listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = sharedPages));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showMutualFriends()
        {
            try
            {
                FacebookObjectCollection<User> mutualFriends = r_Friendships.GetMutualFriends();

                listBoxMutualFriends.Invoke(new Action(() => mutualFriendBindingSource.DataSource = mutualFriends));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showSharedEvents()
        {
            try
            {
                FacebookObjectCollection<Event> sharedEvents = r_Friendships.GetSharedEvents();

                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = sharedEvents));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonFriendshipQuiz_Click(object sender, EventArgs e)
        {
            new FriendshipQuizForm(r_Friendships).ShowDialog();
        }
    }
}

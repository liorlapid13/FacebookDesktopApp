using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MainPage
    {
        private readonly FacebookDataManager r_FacebookDataManager;

        public MainPage()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
        }

        public string GetProfilePicture()
        {
            return r_FacebookDataManager.FetchProfilePicture();
        }

        public string GetUserName()
        {
            return r_FacebookDataManager.FetchFirstName();
        }

        public FacebookObjectCollection<Page> GetPageList()
        {
            return r_FacebookDataManager.FetchLikedPages();
        }

        public FacebookObjectCollection<User> GetFriendsList()
        {
            return r_FacebookDataManager.FetchFriendList();
        }

        public FacebookObjectCollection<Group> GetGroupList()
        {
            return r_FacebookDataManager.FetchGroups();
        }

        public void Logout()
        {
            r_FacebookDataManager.Logout();
        }

        public void PublishPost(string i_PostToPublish)
        {
            r_FacebookDataManager.PublishPost(i_PostToPublish);
        }
    }
}

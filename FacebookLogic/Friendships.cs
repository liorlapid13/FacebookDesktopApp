using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class Friendships
    {
        private readonly FriendshipsManager r_FriendshipManager;
        private readonly FriendshipQuizManager r_FriendshipQuizManager;

        public Friendships()
        {
            r_FriendshipManager = new FriendshipsManager();
            r_FriendshipQuizManager = new FriendshipQuizManager();
        }

        public void SetSelectedFriend(int i_SelectedFriendIndex)
        {
            r_FriendshipManager.SetSelectedFriend(i_SelectedFriendIndex);
            r_FriendshipQuizManager.SetSelectedFriend(r_FriendshipManager.SelectedFriend);
        }

        public FacebookObjectCollection<User> GetFriendList()
        {
            return r_FriendshipManager.FriendList;
        }

        public string GetProfilePicture()
        {
            return r_FriendshipManager.FetchProfilePicture();
        }

        public string GetFriendProfilePicture()
        {
            return r_FriendshipManager.FetchFriendProfilePicture();
        }

        public FacebookObjectCollection<Checkin> GetSharedCheckIns()
        {
            return r_FriendshipManager.FetchSharedCheckIns();
        }

        public FacebookObjectCollection<Page> GetCommonLikedPages()
        {
            return r_FriendshipManager.FetchCommonLikedPages();
        }

        public FacebookObjectCollection<User> GetMutualFriends()
        {
            return r_FriendshipManager.FetchMutualFriends();
        }

        public FacebookObjectCollection<Event> GetSharedEvents()
        {
            return r_FriendshipManager.FetchSharedEvents();
        }

        public string GetFriendFirstName()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendFirstName();
        }

        public string GetFriendBirthday()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendBirthday();
        }

        public string GetFriendCity()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendCity();
        }

        public string GetFriendCountry()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendCountry();
        }

        public string GetFriendRelationshipStatus()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendRelationshipStatus();
        }

        public string GetFriendReligion()
        {
            return r_FriendshipQuizManager.FetchSelectedFriendReligion();
        }
    }
}

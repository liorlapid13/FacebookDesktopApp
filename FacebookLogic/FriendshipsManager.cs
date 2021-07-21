using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendshipsManager
    {
        private readonly FacebookDataManager r_FacebookDataManager;

        public FacebookObjectCollection<User> FriendList { get; private set; }

        public User SelectedFriend { get; private set; }

        public FriendshipsManager()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            FriendList = r_FacebookDataManager.FetchFriendList();
        }

        public void SetSelectedFriend(int i_SelectedFriendIndex)
        {
            SelectedFriend = FriendList[i_SelectedFriendIndex];
        }

        public FacebookObjectCollection<Checkin> FetchSharedCheckIns()
        {
            try
            {
                FacebookObjectCollection<Checkin> checkinList = r_FacebookDataManager.FetchCheckins();
                FacebookObjectCollection<Checkin> sharedCheckinList = new FacebookObjectCollection<Checkin>();

                foreach(Checkin checkin in checkinList)
                {
                    foreach(User taggedUser in checkin.TaggedUsers)
                    {
                        if(taggedUser.Equals(SelectedFriend))
                        {
                            sharedCheckinList.Add(checkin);
                        }
                    }
                }

                return sharedCheckinList;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access user checkins, please try again");
            }
        }

        public FacebookObjectCollection<Page> FetchCommonLikedPages()
        {
            try
            {
                FacebookObjectCollection<Page> userLikedPages = r_FacebookDataManager.FetchLikedPages();
                FacebookObjectCollection<Page> commonLikedPages = new FacebookObjectCollection<Page>();

                foreach(Page likedPage in userLikedPages)
                {
                    foreach(Page friendLikedPage in SelectedFriend.LikedPages)
                    {
                        if(likedPage.Equals(friendLikedPage))
                        {
                            commonLikedPages.Add(likedPage);
                        }
                    }
                }

                return commonLikedPages;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access user liked pages, please try again");
            }
        }

        public FacebookObjectCollection<User> FetchMutualFriends()
        {
            try
            {
                FacebookObjectCollection<User> mutualFriendList = new FacebookObjectCollection<User>();

                foreach(User friend in FriendList)
                {
                    foreach(User friendOfFriend in SelectedFriend.Friends)
                    {
                        if(friend.Equals(friendOfFriend))
                        {
                            mutualFriendList.Add(friend);
                        }
                    }
                }

                return mutualFriendList;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access user friends list, please try again");
            }
        }

        public FacebookObjectCollection<Event> FetchSharedEvents()
        {
            try
            {
                FacebookObjectCollection<Event> userEvents = r_FacebookDataManager.FetchEvents();
                FacebookObjectCollection<Event> sharedEventsList = new FacebookObjectCollection<Event>();

                foreach(Event facebookEvent in userEvents)
                {
                    foreach(Event friendEvent in SelectedFriend.Events)
                    {
                        if(friendEvent.Equals(facebookEvent))
                        {
                            sharedEventsList.Add(facebookEvent);
                        }
                    }
                }

                return sharedEventsList;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access user events, please try again");
            }
        }

        public string FetchFriendProfilePicture()
        {
            try
            {
                return SelectedFriend.PictureNormalURL;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to fetch friend's profile picture, please try again");
            }
        }

        public string FetchProfilePicture()
        {
            return r_FacebookDataManager.FetchProfilePicture();
        }
    }
}

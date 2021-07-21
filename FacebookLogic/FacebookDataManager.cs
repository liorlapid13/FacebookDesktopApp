using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public sealed class FacebookDataManager
    {
        private static FacebookDataManager s_Instance = null;
        private static object s_LockObject = new object();
        private string m_FirstName = null;
        private string m_ProfilePictureURL = null;
        private FacebookObjectCollection<User> m_FriendList = null;
        private FacebookObjectCollection<Page> m_Pages = null;
        private FacebookObjectCollection<Group> m_Groups = null;
        private FacebookObjectCollection<Event> m_Events = null;
        private FacebookObjectCollection<Checkin> m_Checkins = null;
        private FacebookObjectCollection<Post> m_Posts = null;

        public static FacebookDataManager Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock (s_LockObject)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new FacebookDataManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LoggedInUser { get; set; }

        private FacebookDataManager()
        {
        }

        public void Login()
        {
            LoginResult loginResult = FacebookService.Login(
                "293777331735661",
                "groups_access_member_info",
                "user_friends",
                "user_likes",
                "user_link",
                "user_photos",
                "user_videos",
                "user_gender",
                "user_birthday",
                "user_tagged_places",
                "user_hometown",
                "user_posts",
                "user_location",
                "user_events",
                "email");

            if(!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                LoggedInUser = loginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Error: Login unsuccessful, please try again");
            }
        }

        public void Logout()
        {
            FacebookService.Logout(null);
            LoggedInUser = null;
        }

        public FacebookObjectCollection<User> FetchFriendList()
        {
            try
            {
                if(m_FriendList == null)
                {
                    m_FriendList = LoggedInUser.Friends;
                }

                return m_FriendList;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch friend list, please try again");
            }
        }

        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            try
            {
                if(m_Pages == null)
                {
                    m_Pages = LoggedInUser.LikedPages;
                }

                return m_Pages;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch liked pages, please try again");
            }
        }

        public FacebookObjectCollection<Group> FetchGroups()
        {
            try
            {
                if (m_Groups == null)
                {
                    m_Groups = LoggedInUser.Groups;
                }

                return m_Groups;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch groups, please try again");
            }
        }

        public FacebookObjectCollection<Event> FetchEvents()
        {
            try
            {
                if(m_Events == null)
                {
                    m_Events = LoggedInUser.Events;
                }

                return m_Events;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch events, please try again");
            }
        }

        public FacebookObjectCollection<Checkin> FetchCheckins()
        {
            try
            {
                if(m_Checkins == null)
                {
                    m_Checkins = LoggedInUser.Checkins;
                }

                return m_Checkins;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch checkins, please try again");
            }
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            try
            {
                if(m_Posts == null)
                {
                    m_Posts = LoggedInUser.Posts;
                }

                return m_Posts;
            }
            catch (Exception exception)
            {
                throw new Exception("Error: Failed to fetch posts, please try again");
            }
        }

        public string FetchFirstName()
        {
            try
            {
                if(m_FirstName == null)
                {
                    m_FirstName = LoggedInUser.FirstName;
                }

                return m_FirstName;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch user's first name");
            }
        }

        public string FetchProfilePicture()
        {
            try
            {
                if(m_ProfilePictureURL == null)
                {
                    m_ProfilePictureURL = LoggedInUser.PictureNormalURL;
                }

                return m_ProfilePictureURL;
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to fetch profile picture");
            }
        }

        public void PublishPost(string i_PostToPublish)
        {
            try
            {
                LoggedInUser.PostStatus(i_PostToPublish);
            }
            catch(Exception exception)
            {
                throw new Exception("Error: Failed to publish post, please try again");
            }
        }
    }   
}
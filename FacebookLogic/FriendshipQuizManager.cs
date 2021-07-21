using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendshipQuizManager
    {
        private User m_SelectedFriend;

        public void SetSelectedFriend(User i_SelectedFriend)
        {
            m_SelectedFriend = i_SelectedFriend;
        }

        public string FetchSelectedFriendFirstName()
        {
            return m_SelectedFriend.FirstName;
        }

        public string FetchSelectedFriendBirthday()
        {
            return m_SelectedFriend.Birthday;
        }

        public string FetchSelectedFriendCity()
        {
            return m_SelectedFriend.Location.Location.City;
        }

        public string FetchSelectedFriendCountry()
        {
            return m_SelectedFriend.Location.Location.Country;
        }

        public string FetchSelectedFriendRelationshipStatus()
        {
            return m_SelectedFriend.RelationshipStatus.ToString();
        }

        public string FetchSelectedFriendReligion()
        {
            return m_SelectedFriend.Religion;
        }
    }
}
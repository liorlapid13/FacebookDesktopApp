using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public abstract class FriendsFilter
    {
        public FacebookObjectCollection<User> FilterFriendsList()
        {
            FacebookObjectCollection<User> filteredFriendsList = new FacebookObjectCollection<User>();

            FilterFriends(filteredFriendsList);

            return filteredFriendsList;
        }

        protected abstract void FilterFriends(FacebookObjectCollection<User> io_FilteredFriendsList);
    }
}

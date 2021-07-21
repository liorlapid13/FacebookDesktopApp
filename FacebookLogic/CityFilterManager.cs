using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class CityFilterManager : FriendsFilter
    {
        private const string k_FailedToFetchCity = "Error: Failed to fetch city, please try again";

        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly FacebookObjectCollection<User> r_FriendList;

        public string SelectedCity { get; set; }

        public CityFilterManager()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            r_FriendList = r_FacebookDataManager.FetchFriendList();
        }

        protected override void FilterFriends(FacebookObjectCollection<User> io_FilteredFriendList)
        {
            try
            {
                foreach (User friend in r_FriendList)
                {
                    if (string.Equals(friend.Location.Location.City, SelectedCity))
                    {
                        io_FilteredFriendList.Add(friend);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(k_FailedToFetchCity);
            }
        }
    }
}

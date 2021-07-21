using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class CountryFilterManager : FriendsFilter
    {
        private const string k_FailedToFetchCountry = "Error: Failed to fetch country, please try again";

        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly FacebookObjectCollection<User> r_FriendList;

        public string SelectedCountry { get; set; }

        public CountryFilterManager()
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
                    if (string.Equals(friend.Location.Location.Country, SelectedCountry))
                    {
                        io_FilteredFriendList.Add(friend);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(k_FailedToFetchCountry);
            }
        }
    }
}

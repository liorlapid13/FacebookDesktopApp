using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class GenderFilterManager : FriendsFilter
    {
        private const string k_FailedToFetchGender = "Error: Failed to fetch gender, please try again";

        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly FacebookObjectCollection<User> r_FriendList;

        public string SelectedGender { get; set; }

        public GenderFilterManager()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            r_FriendList = r_FacebookDataManager.FetchFriendList();
        }

        protected override void FilterFriends(FacebookObjectCollection<User> io_FilteredFriendList)
        {
            try
            {
                User.eGender selectedGenderFilter = string.Equals(SelectedGender, "Male")
                                                        ? User.eGender.male
                                                        : User.eGender.female;

                foreach (User friend in r_FriendList)
                {
                    if (friend.Gender == selectedGenderFilter)
                    {
                        io_FilteredFriendList.Add(friend);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(k_FailedToFetchGender);
            }
        }
    }
}

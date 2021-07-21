using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class GroupsFilterManager : FriendsFilter
    {
        private const string k_FailedToFetchGroups = "Error: Failed to fetch groups, please try again";

        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly FacebookObjectCollection<User> r_FriendList;

        public GroupsFilterManager()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            r_FriendList = r_FacebookDataManager.FetchFriendList();
        }

        protected override void FilterFriends(FacebookObjectCollection<User> io_FilteredFriendList)
        {
            try
            {
                FacebookObjectCollection<Group> groupList = r_FacebookDataManager.FetchGroups();

                foreach (User friend in r_FriendList)
                {
                    bool friendHasBeenAdded = false;

                    foreach (Group group in groupList)
                    {
                        foreach (Group friendGroup in friend.Groups)
                        {
                            if (friendGroup.Equals(group))
                            {
                                io_FilteredFriendList.Add(friend);
                                friendHasBeenAdded = true;
                            }

                            if (friendHasBeenAdded)
                            {
                                break;
                            }
                        }

                        if (friendHasBeenAdded)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(k_FailedToFetchGroups);
            }
        }
    }
}

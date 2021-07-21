using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class AdvancedFriendFilters
    {
        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly GenderFilterManager r_GenderFilterManager;
        private readonly CityFilterManager r_CityFilterManager;
        private readonly CountryFilterManager r_CountryFilterManager;
        private readonly PagesFilterManager r_PagesFilterManager;
        private readonly GroupsFilterManager r_GroupsFilterManager;

        public int SelectedFilterIndex { get; set; }

        public string SelectedFilterSpecification { get; set; }

        public enum eFilterOptions
        {
            Gender = 0,
            City,
            Country,
            CommonLikedPages,
            CommonGroups
        }

        public AdvancedFriendFilters()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            r_GenderFilterManager = new GenderFilterManager();
            r_CityFilterManager = new CityFilterManager();
            r_CountryFilterManager = new CountryFilterManager();
            r_PagesFilterManager = new PagesFilterManager();
            r_GroupsFilterManager = new GroupsFilterManager();
        }
        
        public FacebookObjectCollection<User> GetFilteredFriendList()
        {
            return fetchFilteredFriends();
        }

        public string GetProfilePicture()
        {
            return r_FacebookDataManager.FetchProfilePicture();
        }

        private FacebookObjectCollection<User> fetchFilteredFriends()
        {
            try
            {
                FacebookObjectCollection<User> filteredFriendList = new FacebookObjectCollection<User>();

                switch ((eFilterOptions)SelectedFilterIndex)
                {
                    case eFilterOptions.Gender:
                        r_GenderFilterManager.SelectedGender = SelectedFilterSpecification;
                        filteredFriendList = r_GenderFilterManager.FilterFriendsList();
                        break;
                    case eFilterOptions.City:
                        r_CityFilterManager.SelectedCity = SelectedFilterSpecification;
                        filteredFriendList = r_CityFilterManager.FilterFriendsList();
                        break;
                    case eFilterOptions.Country:
                        r_CountryFilterManager.SelectedCountry = SelectedFilterSpecification;
                        filteredFriendList = r_CountryFilterManager.FilterFriendsList();
                        break;
                    case eFilterOptions.CommonLikedPages:
                        filteredFriendList = r_PagesFilterManager.FilterFriendsList();
                        break;
                    case eFilterOptions.CommonGroups:
                        filteredFriendList = r_GroupsFilterManager.FilterFriendsList();
                        break;
                }

                return filteredFriendList;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}

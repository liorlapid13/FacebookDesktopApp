using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class AdvancedFriendFiltersForm : Form
    {
        private const string k_NoFilterSelectedError = "You must select a filter, please try again";

        private readonly AdvancedFriendFilters r_AdvancedFriendFilters;

        public AdvancedFriendFiltersForm()
        {
            r_AdvancedFriendFilters = new AdvancedFriendFilters();
            InitializeComponent();
            profilePictureBox.ImageLocation = r_AdvancedFriendFilters.GetProfilePicture();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(filtersComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(k_NoFilterSelectedError);
            }
            else
            {
                try
                {
                    r_AdvancedFriendFilters.SelectedFilterIndex = filtersComboBox.SelectedIndex;

                    switch ((AdvancedFriendFilters.eFilterOptions)filtersComboBox.SelectedIndex)
                    {
                        case AdvancedFriendFilters.eFilterOptions.Gender:
                            new GenderFilterForm(r_AdvancedFriendFilters).ShowDialog();
                            break;
                        case AdvancedFriendFilters.eFilterOptions.City:
                            new LocationFilterForm(r_AdvancedFriendFilters, AdvancedFriendFilters.eFilterOptions.City)
                                .ShowDialog();
                            break;
                        case AdvancedFriendFilters.eFilterOptions.Country:
                            new LocationFilterForm(r_AdvancedFriendFilters, AdvancedFriendFilters.eFilterOptions.Country)
                                .ShowDialog();
                            break;
                    }

                    userBindingSource.DataSource = r_AdvancedFriendFilters.GetFilteredFriendList();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

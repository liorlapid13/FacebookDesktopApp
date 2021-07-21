using System;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class LocationFilterForm : Form
    {
        private const string k_NoCityEntered = "You must enter a city, please try again";

        private readonly AdvancedFriendFilters r_AdvancedFriendFilters;

        public LocationFilterForm(
            AdvancedFriendFilters i_AdvancedFriendFilters,
            AdvancedFriendFilters.eFilterOptions i_SelectedFilter)
        {
            r_AdvancedFriendFilters = i_AdvancedFriendFilters;
            InitializeComponent();
            initializeFormLabels(i_SelectedFilter);
        }

        private void initializeFormLabels(AdvancedFriendFilters.eFilterOptions i_SelectedFilter)
        {
            if(i_SelectedFilter == AdvancedFriendFilters.eFilterOptions.City)
            {
                Text = "City Filter Form";
                filterByLocationLabel.Text = "Filter by City";
                enterALocationLabel.Text = "Please enter a city:";
            }
            else
            {
                Text = "Country Filter Form";
                filterByLocationLabel.Text = "Filter by Country";
                enterALocationLabel.Text = "Please enter a country:";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show(k_NoCityEntered); 
            }
            else
            {
                r_AdvancedFriendFilters.SelectedFilterSpecification = cityTextBox.Text;
                Close();
            }
        }
    }
}

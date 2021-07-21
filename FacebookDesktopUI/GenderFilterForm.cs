using System;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class GenderFilterForm : Form
    {
        private const string k_NoGenderSelected = "You must select a gender, please try again";

        private readonly AdvancedFriendFilters r_AdvancedFriendFilters;

        public GenderFilterForm(AdvancedFriendFilters i_AdvancedFriendFilters)
        {
            r_AdvancedFriendFilters = i_AdvancedFriendFilters;
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(genderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(k_NoGenderSelected);
            }
            else
            {
                r_AdvancedFriendFilters.SelectedFilterSpecification = genderComboBox.Text;
                Close();
            }
        }
    }
}
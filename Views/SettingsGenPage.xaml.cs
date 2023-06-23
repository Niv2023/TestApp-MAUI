using TestApp.Models;


namespace TestApp.Views
{
    public partial class SettingsGenPage : ContentPage
    {
        public SettingsGenPage()
        {
            InitializeComponent();
            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;
            PickerLanguages.SelectedIndex =  Languages.IndexOf(AppData.Language);
        }
        private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AppData.Language =  Languages.Available[PickerLanguages.SelectedIndex].ShortName;
            }
            catch (Exception)
            {
            }
        }
    }
}

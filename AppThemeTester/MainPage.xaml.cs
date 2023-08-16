using AppThemeTester.Resources.Styles;

namespace AppThemeTester
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var theme = (Theme) picker.SelectedItem;

            ICollection<ResourceDictionary> mergedDicts = Application.Current.Resources.MergedDictionaries;

            if (mergedDicts != null)
            {
                mergedDicts.Clear();

                switch (theme)
                {
                    case Theme.Default:
                        mergedDicts.Add(new ThemeOne());
                        break;
                    case Theme.ThemeOne:
                    default:
                        mergedDicts.Add(new ThemeOne());
                        break;
                }
            }
        }
    }
}
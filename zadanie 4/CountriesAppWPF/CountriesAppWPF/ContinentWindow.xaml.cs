using System.Windows;
using System.Xml;

namespace CountriesAppWPF {
    /// <summary>
    /// Logika interakcji dla klasy ContinentWindow.xaml
    /// </summary>
    public partial class ContinentWindow : Window {
        private XmlElement continent;

        public ContinentWindow(XmlElement continent) {
            InitializeComponent();
            this.continent = continent;
            DataContext = this.continent;
        }

        private void OpenCountry_Click(object sender, RoutedEventArgs e) {
            if (CountryListBox.SelectedItem != null) {
                var selectedCountry = (XmlElement)CountryListBox.SelectedItem;
                var countryWindow = new CountryWindow(selectedCountry);
                countryWindow.Show();
            }
            else {
                MessageBox.Show("Please select a country.");
            }
        }
    }
}
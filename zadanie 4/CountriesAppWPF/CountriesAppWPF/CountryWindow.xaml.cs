using System.Windows;
using System.Xml;

namespace CountriesAppWPF {
    /// <summary>
    /// Logika interakcji dla klasy CountryWindow.xaml
    /// </summary>
    public partial class CountryWindow : Window {
        private XmlElement country;

        public CountryWindow(XmlElement country) {
            InitializeComponent();
            this.country = country;
            DataContext = this.country;
        }
    }
}

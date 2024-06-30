using System.Windows;
using System.Xml;

namespace CountriesAppWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OpenContinent_Click(object sender, RoutedEventArgs e) {
            if (ContinentListBox.SelectedItem != null) {
                var selectedContinent = (XmlElement)ContinentListBox.SelectedItem;
                var continentWindow = new ContinentWindow(selectedContinent);
                continentWindow.Show();
            }
            else {
                MessageBox.Show("Please select a continent.");
            }
        }
    }
}

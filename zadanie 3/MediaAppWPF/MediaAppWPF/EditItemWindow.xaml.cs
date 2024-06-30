using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MediaAppWPF {
    /// <summary>
    /// Logika interakcji dla klasy EditItemWindow.xaml
    /// </summary>
    public partial class EditItemWindow : Window {
        public EditItemWindow(MediaItem mediaItem) {
            InitializeComponent();
            DataContext = mediaItem;
        }

        private void OK_Click(object sender, RoutedEventArgs e) {
            DialogResult = true;
        }
    }
}

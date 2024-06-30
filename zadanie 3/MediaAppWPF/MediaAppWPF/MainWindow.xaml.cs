using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaAppWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private ObservableCollection<MediaItem> mediaItems;
        public MainWindow() {
            InitializeComponent();
            mediaItems = new ObservableCollection<MediaItem>();

            MediaListBox.ItemsSource = mediaItems;
        }
        private void Add_Click(object sender, RoutedEventArgs e) {
            var newItem = new MediaItem { ReleaseDate = DateTime.Now };
            var editWindow = new EditItemWindow(newItem);
            if (editWindow.ShowDialog() == true) {
                mediaItems.Add(newItem);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e) {
            if (MediaListBox.SelectedItem is MediaItem selectedMediaItem) {
                var editWindow = new EditItemWindow(selectedMediaItem);
                editWindow.ShowDialog();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            if (MediaListBox.SelectedItem is MediaItem selectedMediaItem) {
                mediaItems.Remove(selectedMediaItem);
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true) {
                var lines = File.ReadAllLines(openFileDialog.FileName);
                mediaItems.Clear();
                foreach (var line in lines) {
                    var values = line.Split(',');
                    if (values.Length == 5) {
                        mediaItems.Add(new MediaItem {
                            Title = values[0],
                            AuthorOrDirector = values[1],
                            PublisherOrStudio = values[2],
                            MediaType = values[3],
                            ReleaseDate = DateTime.Parse(values[4])
                        });
                    }
                }
            }
        }

        private void Export_Click(object sender, RoutedEventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == true) {
                var lines = new List<string>();
                foreach (var item in mediaItems) {
                    lines.Add($"{item.Title},{item.AuthorOrDirector},{item.PublisherOrStudio},{item.MediaType},{item.ReleaseDate:yyyy-MM-dd}");
                }
                File.WriteAllLines(saveFileDialog.FileName, lines);
            }
        }
    }
}

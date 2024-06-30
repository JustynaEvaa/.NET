using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAppWPF {
    public class MediaItem : INotifyPropertyChanged {
        private string title;
        private string authorOrDirector;
        private string publisherOrStudio;
        private string mediaType;
        private DateTime releaseDate;

        public string Title {
            get => title;
            set {
                if (title != value) {
                    title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public string AuthorOrDirector {
            get => authorOrDirector;
            set {
                if (authorOrDirector != value) {
                    authorOrDirector = value;
                    OnPropertyChanged(nameof(AuthorOrDirector));
                }
            }
        }

        public string PublisherOrStudio {
            get => publisherOrStudio;
            set {
                if (publisherOrStudio != value) {
                    publisherOrStudio = value;
                    OnPropertyChanged(nameof(PublisherOrStudio));
                }
            }
        }

        public string MediaType {
            get => mediaType;
            set {
                if (mediaType != value) {
                    mediaType = value;
                    OnPropertyChanged(nameof(MediaType));
                }
            }
        }

        public DateTime ReleaseDate {
            get => releaseDate;
            set {
                if (releaseDate != value) {
                    releaseDate = value;
                    OnPropertyChanged(nameof(ReleaseDate));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

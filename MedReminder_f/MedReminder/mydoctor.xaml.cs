using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Phone.Controls;

namespace MedReminder
{
    public partial class mydoctor : PhoneApplicationPage, INotifyPropertyChanged
    {
        private AddDocDataContext addDocDB;
        private ObservableCollection<AddDocItem> _addDocItems;
        public ObservableCollection<AddDocItem> AddDocItems
        {
            get
            {
                return _addDocItems;
            }
            set
            {
                if (_addDocItems != value)
                {
                    _addDocItems = value;
                    NotifyPropertyChanged("AddDocItems");
                }
            }
        }
        public mydoctor()
        {
            InitializeComponent();
            addDocDB = new AddDocDataContext(AddDocDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void adddoctor(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/mydoctoradd.xaml", UriKind.Relative));
        }

        private void deleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                AddDocItem addDocForDelete = button.DataContext as AddDocItem;
                AddDocItems.Remove(addDocForDelete);
                addDocDB.AddDocItems.DeleteOnSubmit(addDocForDelete);
                addDocDB.SubmitChanges();
                this.Focus();
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var addDocItemsInDB = from AddDocItem adddoc in addDocDB.AddDocItems
                                select adddoc;
            AddDocItems = new ObservableCollection<AddDocItem>(addDocItemsInDB);
            base.OnNavigatedTo(e);
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
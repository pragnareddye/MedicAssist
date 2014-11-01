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
    public partial class appointment : PhoneApplicationPage, INotifyPropertyChanged
    {
        private ToDoDataContext toDoDB;
        private ObservableCollection<ToDoItem> _toDoItems;
        public ObservableCollection<ToDoItem> ToDoItems
        {
            get
            {
                return _toDoItems;
            }
            set
            {
                if (_toDoItems != value)
                {
                    _toDoItems = value;
                    NotifyPropertyChanged("ToDoItems");
                }
            }
        }
        public appointment()
        {
            InitializeComponent();
            toDoDB = new ToDoDataContext(ToDoDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void appointmentadd(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/appointmentadd.xaml", UriKind.Relative));
        }

        private void deleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                ToDoItem toDoForDelete = button.DataContext as ToDoItem;
                ToDoItems.Remove(toDoForDelete);
                toDoDB.ToDoItems.DeleteOnSubmit(toDoForDelete);
                toDoDB.SubmitChanges();
                this.Focus();
            }
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var toDoItemsInDB = from ToDoItem todo in toDoDB.ToDoItems
                                select todo;
            ToDoItems = new ObservableCollection<ToDoItem>(toDoItemsInDB);
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
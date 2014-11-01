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
    public partial class healthtrack : PhoneApplicationPage, INotifyPropertyChanged
    {
        private AddDrugDataContext addHrecordDB;
        private ObservableCollection<AddHrecordItem> _addHrecordItems;
        public ObservableCollection<AddHrecordItem> AddHrecordItems
        {
            get
            {
                return _addHrecordItems;
            }
            set
            {
                if (_addHrecordItems != value)
                {
                    _addHrecordItems = value;
                    NotifyPropertyChanged("AddHrecordItems");
                }
            }
        }

        public healthtrack()
        {
            InitializeComponent();
            addHrecordDB = new AddDrugDataContext(AddDrugDataContext.DBConnectionString);
            this.DataContext = this;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var addHrecordItemsInDB = from AddHrecordItem addhrecord in addHrecordDB.AddHrecordItems
                                  select addhrecord;
            AddHrecordItems = new ObservableCollection<AddHrecordItem>(addHrecordItemsInDB);
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
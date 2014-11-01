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
    public partial class mydoctoradd : PhoneApplicationPage
    {
        private AddDocDataContext addDocDB;
        public mydoctoradd()
        {
            InitializeComponent();
            addDocDB = new AddDocDataContext(AddDocDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void savedoctor(object sender, EventArgs e)
        {
            AddDocItem newAddDoc = new AddDocItem()
            {
                ItemName = docname.Text,
                ItemName1 = docspec.Text,
                ItemName2 = doccontact.Text,
                ItemName3 = docaddr.Text
            };

            addDocDB.AddDocItems.InsertOnSubmit(newAddDoc);
            this.NavigationService.GoBack();
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            addDocDB.SubmitChanges();
        }
    }

    public class AddDocDataContext : DataContext
    {
        public static string DBConnectionString = "Data Source=isostore:/AddDoc.sdf";

        public AddDocDataContext(string connectionString)
            : base(connectionString)
        { }
        public Table<AddDocItem> AddDocItems;
    }

    [Table]
    public class AddDocItem : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _addDocItemsId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int AddDocItemsId
        {
            get
            {
                return _addDocItemsId;
            }
            set
            {
                if (_addDocItemsId != value)
                {
                    NotifyPropertyChanging("AddDocItemsId");
                    _addDocItemsId = value;
                    NotifyPropertyChanged("AddDocItemsId");
                }
            }
        }

        private string _itemName;

        [Column]
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                if (_itemName != value)
                {
                    NotifyPropertyChanging("ItemName");
                    _itemName = value;
                    NotifyPropertyChanged("ItemName");
                }
            }
        }

        private string _itemName1;

        [Column]
        public string ItemName1
        {
            get
            {
                return _itemName1;
            }
            set
            {
                if (_itemName1 != value)
                {
                    NotifyPropertyChanging("ItemName1");
                    _itemName1 = value;
                    NotifyPropertyChanged("ItemName1");
                }
            }
        }

        private string _itemName2;

        [Column]
        public string ItemName2
        {
            get
            {
                return _itemName2;
            }
            set
            {
                if (_itemName2 != value)
                {
                    NotifyPropertyChanging("ItemName2");
                    _itemName2 = value;
                    NotifyPropertyChanged("ItemName2");
                }
            }
        }

        private string _itemName3;

        [Column]
        public string ItemName3
        {
            get
            {
                return _itemName3;
            }
            set
            {
                if (_itemName3 != value)
                {
                    NotifyPropertyChanging("ItemName3");
                    _itemName3 = value;
                    NotifyPropertyChanged("ItemName3");
                }
            }
        }

        [Column(IsVersion = true)]
        private Binary _version;

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

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion
    }
}
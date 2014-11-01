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
    public partial class appointmentadd : PhoneApplicationPage
    {
        private ToDoDataContext toDoDB;
        public appointmentadd()
        {
            InitializeComponent();
            toDoDB = new ToDoDataContext(ToDoDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void saveappointment(object sender, EventArgs e)
        {
            DateTime time = (DateTime)appdate.Value;
            DateTime time1 = (DateTime)apptime.Value;
            ToDoItem newToDo = new ToDoItem()
            { ItemName = appdoctorname.Text,
              ItemName1 = time.ToString("d") + "     "+time1.ToString("t")
            };

            toDoDB.ToDoItems.InsertOnSubmit(newToDo);
            this.NavigationService.GoBack();
        }
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            toDoDB.SubmitChanges();
        }
    }

    public class ToDoDataContext : DataContext
    {
        public static string DBConnectionString = "Data Source=isostore:/ToDo.sdf";
        public ToDoDataContext(string connectionString)
            : base(connectionString)
        { }
        public Table<ToDoItem> ToDoItems;
    }

    [Table]
    public class ToDoItem : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _toDoItemId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int ToDoItemId
        {
            get
            {
                return _toDoItemId;
            }
            set
            {
                if (_toDoItemId != value)
                {
                    NotifyPropertyChanging("ToDoItemId");
                    _toDoItemId = value;
                    NotifyPropertyChanged("ToDoItemId");
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
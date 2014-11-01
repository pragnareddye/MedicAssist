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
using Microsoft.Phone.Scheduler;

namespace MedReminder
{
    public partial class druglistadd : PhoneApplicationPage
    {
        private AddDrugDataContext addDrugDB;
        public druglistadd()
        {
            InitializeComponent();
            addDrugDB = new AddDrugDataContext(AddDrugDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void addalaram(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string alarmName = Guid.NewGuid().ToString();
            Reminder alarm = new Reminder(alarmName);
            MessageBox.Show(alarmName);
            alarm.Title = this.medname.Text;
            alarm.Content = this.alarmContent.Text;
            Int32 t = Convert.ToInt32(this.course.Text);
            ScheduledActionService.Find("next");

 
            DateTime time = (DateTime)timePicker1.Value;

            DateTime today = DateTime.Now;
            DateTime beginTime =time;
            alarm.BeginTime = beginTime;
            alarm.ExpirationTime = alarm.BeginTime.AddDays(t);
            alarm.RecurrenceType = RecurrenceInterval.Daily;
            ScheduledActionService.Add(alarm);

            this.RefreshAlarmList();


        }

        private void removealarm(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Reminder selectedAlarm = this.lbAlarms.SelectedItem as Reminder;
            ScheduledActionService.Remove(selectedAlarm.Name);
            this.RefreshAlarmList();
        }

        private void RefreshAlarmList()
        {
            IEnumerable<Reminder> alarms = ScheduledActionService.GetActions<Reminder>();
            this.lbAlarms.ItemsSource = alarms;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.RefreshAlarmList();
        }

        private void savedruglist(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            AddHrecordItem newAddHrecord = new AddHrecordItem()
            {
                ItemName = date.ToString("d"),
                ItemName1 = alarmContent.Text,
                ItemName2 = medname.Text
            };
            addDrugDB.AddHrecordItems.InsertOnSubmit(newAddHrecord);

            AddDrugItem newAddDrug = new AddDrugItem()
            {
                ItemName = medname.Text,
                ItemName1 = dose.Text,
                ItemName2 = course.Text,
                ItemName3 = alarmContent.Text
            };

            addDrugDB.AddDrugItems.InsertOnSubmit(newAddDrug);
            this.NavigationService.GoBack();
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            addDrugDB.SubmitChanges();
        }
    }

    public class AddDrugDataContext : DataContext
    {
        public static string DBConnectionString = "Data Source=isostore:/AddDrug.sdf";

        public AddDrugDataContext(string connectionString)
            : base(connectionString)
        { }
        public Table<AddDrugItem> AddDrugItems;
        public Table<AddHrecordItem> AddHrecordItems;
    }

    [Table]
    public class AddDrugItem : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _addDrugItemsId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int AddDrugItemsId
        {
            get
            {
                return _addDrugItemsId;
            }
            set
            {
                if (_addDrugItemsId != value)
                {
                    NotifyPropertyChanging("AddDrugItemsId");
                    _addDrugItemsId = value;
                    NotifyPropertyChanged("AddDrugItemsId");
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


    //healtHrecord
    [Table]
    public class AddHrecordItem : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _addHrecordItemsId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int AddHrecordItemsId
        {
            get
            {
                return _addHrecordItemsId;
            }
            set
            {
                if (_addHrecordItemsId != value)
                {
                    NotifyPropertyChanging("AddHrecordItemsId");
                    _addHrecordItemsId = value;
                    NotifyPropertyChanged("AddHrecordItemsId");
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
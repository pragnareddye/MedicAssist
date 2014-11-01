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
    public partial class druglist : PhoneApplicationPage, INotifyPropertyChanged
    {
        private AddDrugDataContext addDrugDB;
        private ObservableCollection<AddDrugItem> _addDrugItems;
        public ObservableCollection<AddDrugItem> AddDrugItems
        {
            get
            {
                return _addDrugItems;
            }
            set
            {
                if (_addDrugItems != value)
                {
                    _addDrugItems = value;
                    NotifyPropertyChanged("AddDrugItems");
                }
            }
        }

        public druglist()
        {
            InitializeComponent();
            addDrugDB = new AddDrugDataContext(AddDrugDataContext.DBConnectionString);
            this.DataContext = this;
        }

        private void addcontent(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/druglistadd.xaml", UriKind.Relative)); 
        }
                
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var addDrugItemsInDB = from AddDrugItem adddrug in addDrugDB.AddDrugItems
                                  select adddrug;
            AddDrugItems = new ObservableCollection<AddDrugItem>(addDrugItemsInDB);
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

        private void deleteTaskButton_Click(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var button = sender as Image;
         
             MessageBoxResult mb =  MessageBox.Show("do you want to remove the medicine?", "confirmation", MessageBoxButton.OKCancel);

             if (mb != MessageBoxResult.OK)
             {
                 //e.Cancel = true;
             }
             else
             {
                 AddDrugItem addDrugForDelete = button.DataContext as AddDrugItem;
                 AddDrugItems.Remove(addDrugForDelete);
                 addDrugDB.AddDrugItems.DeleteOnSubmit(addDrugForDelete);
                 addDrugDB.SubmitChanges();
                 this.Focus();
             }

        
            
        }
    }
}
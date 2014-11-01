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
using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;

namespace MedReminder
{
    public partial class reminder : PhoneApplicationPage
    {
        public reminder()
        {
            InitializeComponent();
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

        private void removealarm(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Reminder selectedAlarm = this.lbAlarms.SelectedItem as Reminder;
            ScheduledActionService.Remove(selectedAlarm.Name);
            this.RefreshAlarmList();
        }
    }
}
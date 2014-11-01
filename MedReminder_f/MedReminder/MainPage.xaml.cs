#define DEBUG_AGENT

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

using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Notification;



namespace MedReminder
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string periodicTaskName = "LiveTilePeriodicAgent";
        private PeriodicTask periodicTask;
        HttpNotificationChannel pushChannel;
        // The name of our push channel.
        string channelName = "LiveTileChannel";
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           // CreatePushChannel();
            Random random = new Random();
            // get application tile
            ShellTile tile = ShellTile.ActiveTiles.First();
            if (null != tile)
            {
                // creata a new data for tile
                StandardTileData data = new StandardTileData();
                // tile foreground data
                data.Title = "Title text here";
                
                
            
                data.BackgroundImage = new Uri("/Images/Blue.jpg", UriKind.Relative);
                data.Count = random.Next(99);
                // to make tile flip add data to background also
                data.BackTitle = "Secret text here";
                data.BackBackgroundImage = new Uri("/Images/Green.jpg", UriKind.Relative);

                data.BackContent = "your next medicine should be taken in ";
                // update tile
                tile.Update(data);

            }
        }
        private void CreatePushChannel()
        {
            // Try to find the push channel.
            pushChannel = HttpNotificationChannel.Find(channelName);

            // If the channel was not found, then create a new connection to the push service.
            if (pushChannel == null)
            {
                pushChannel = new HttpNotificationChannel(channelName);

                // Register for all the events before attempting to open the channel.
                pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(PushChannel_ChannelUriUpdated);
                pushChannel.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(PushChannel_ErrorOccurred);

                pushChannel.Open();

                // Bind this new channel for Tile events.
                pushChannel.BindToShellTile();
            }
            else
            {
                // The channel was already open, so just register for all the events.
                pushChannel.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(PushChannel_ChannelUriUpdated);
                pushChannel.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(PushChannel_ErrorOccurred);

                // Display the URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
                System.Diagnostics.Debug.WriteLine(pushChannel.ChannelUri.ToString());
                //MessageBox.Show(String.Format("Channel Uri is {0}", pushChannel.ChannelUri.ToString()));
            }
        }
        void PushChannel_ChannelUriUpdated(object sender, NotificationChannelUriEventArgs e)
        {

            Dispatcher.BeginInvoke(() =>
            {
                // Display the new URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
                System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString());
                //MessageBox.Show(String.Format("Channel Uri is {0}", e.ChannelUri.ToString()));
            });
        }

        /// <summary>
        /// Event handler for when a Push Notification error occurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PushChannel_ErrorOccurred(object sender, NotificationChannelErrorEventArgs e)
        {
            // Error handling logic for your particular application would be here.
            Dispatcher.BeginInvoke(() =>
                MessageBox.Show(String.Format("A push notification {0} error occurred.  {1} ({2}) {3}", e.ErrorType, e.Message, e.ErrorCode, e.ErrorAdditionalData)));
        }

        /// <summary>
        /// Event handler for when the Push Channel Uri changes.
        private void drugclick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/druglist.xaml", UriKind.Relative));
        }

        private void reminder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/reminder.xaml", UriKind.Relative));
        }

        private void pillidentifier(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/pillidentifier.xaml", UriKind.Relative));
        }

        private void healthtrack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/healthtrack.xaml", UriKind.Relative));
        }

        private void graph(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/graph.xaml", UriKind.Relative));
        }

        private void sideeffect(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/sideeffect.xaml", UriKind.Relative));
        }

        private void mydoctor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/mydoctor.xaml", UriKind.Relative));
        }

        private void finddrug(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/finddrug.xaml", UriKind.Relative));
        }

        private void appointment(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/appointment.xaml", UriKind.Relative));
        }
    }
}
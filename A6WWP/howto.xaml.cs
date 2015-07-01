using A6WWP.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace A6WWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class howto : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        int imgChanged = 0;
        public howto()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0,0,2);
            bool enabled = timer.IsEnabled; 
            timer.Start();
        }
        void timer_Tick(object sender, object e)
        {
            if (imgChanged == 0)
            {
                exercise1.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_1.png"));
                exercise2.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/2_1.png"));
                exercise3.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/3_1.png"));
                exercise4.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/4_1.png"));
                exercise5.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/5_1.png"));
                exercise6.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/6_1.png"));
                imgChanged = 1;
                return;
            }
            if(imgChanged == 1)
            {
                exercise1.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise2.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise3.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise4.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise5.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/5_2.png"));
                exercise6.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                imgChanged = 2;
                return;
            }
            if (imgChanged == 2)
            {
                exercise1.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_2.png"));
                exercise2.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/2_1.png"));
                exercise3.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/3_2.png"));
                exercise4.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/4_1.png"));
                exercise5.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/5_1.png"));
                exercise6.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/6_1.png"));
                imgChanged = 3;
                return;
            }
            if (imgChanged == 3)
            {
                exercise1.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise2.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise3.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise4.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                exercise5.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/5_2.png"));
                exercise6.Source = new BitmapImage(new Uri("ms-appx:/Assets/a6w/1_3.png"));
                imgChanged = 0;
                return;
            }

        }
        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}

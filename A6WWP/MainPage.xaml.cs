using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace A6WWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class Step
    {
        public string Image { get; set; }
        public string TimeDo {get;set;}
        public string Cycle {get;set;}

        public string MusicUrl { get; set; }

        public string BaiTap { get; set; }
    }
    
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer dispatcherTimer;
        List<Step> Steps;
        int index = 0;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            
            Steps = new List<Step>
            { 
                new Step{},
                new Step{MusicUrl="ms-appx:///Assets/a6w/get ready.mp3"},
                new Step{},
                new Step{MusicUrl="ms-appx:///Assets/a6w/5.mp3"},
                new Step{MusicUrl="ms-appx:///Assets/a6w/4.mp3"},
                new Step{MusicUrl="ms-appx:///Assets/a6w/3.mp3"},
                new Step{MusicUrl="ms-appx:///Assets/a6w/2.mp3"},
                new Step{MusicUrl="ms-appx:///Assets/a6w/1.mp3"},
                new Step{MusicUrl="ms-appx:///Assets/a6w/go.mp3"},
            

            #region //// exercise 1
            new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex1.mp3",Cycle = "1/6",BaiTap = "1"},
            new Step{},
            new Step{TimeDo = "0", Cycle = "1/6",MusicUrl="ms-appx:///Assets/a6w/up.mp3",BaiTap="1"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_2.png",Cycle = "2/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_1.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_2.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_1.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/1_2.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            #endregion

            #region //// exercise 2
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex2.mp3",Cycle = "1/6",BaiTap = "2"},
            new Step{},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "1/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "2/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "3/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "4/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "5/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/2_1.png",Cycle = "6/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            #endregion

            #region //// exercise 3
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex3.mp3",Cycle = "1/6",BaiTap = "3"},
            new Step{},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "1/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_2.png",Cycle = "2/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_1.png",Cycle = "3/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_2.png",Cycle = "4/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_1.png",Cycle = "5/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/3_2.png",Cycle = "6/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            #endregion

            #region //// exercise 4
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex4.mp3",Cycle = "1/6",BaiTap = "4"},
            new Step{},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "1/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "2/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "3/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "4/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "5/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
            new Step{TimeDo = "3",Image="Assets/a6w/4_1.png",Cycle = "6/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
            new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
            new Step{TimeDo = "0"},
            #endregion

            #region //// exercise 5
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex5.mp3",Cycle = "1/6",BaiTap = "5"},
                new Step{},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/5_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/5_2.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/switch.mp3"},
                new Step{TimeDo = "3", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/5_1.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/switch.mp3"},
                new Step{TimeDo = "3", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/5_2.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/switch.mp3"},
                new Step{TimeDo = "3", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/5_1.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/switch.mp3"},
                new Step{TimeDo = "3", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/5_2.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/switch.mp3"},
                new Step{TimeDo = "3", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
            #endregion

            #region //// exercise 6
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0",MusicUrl="ms-appx:///Assets/a6w/ex6.mp3",Cycle = "1/6",BaiTap = "6"},
                new Step{},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "1/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "1/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "2/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "2/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "3/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "3/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "4/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "4/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "5/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "5/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
                new Step{TimeDo = "0", MusicUrl="ms-appx:///Assets/a6w/up.mp3"},
                new Step{TimeDo = "3",Image="Assets/a6w/6_1.png",Cycle = "6/6", MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "2",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "1",MusicUrl="ms-appx:///Assets/a6w/beep-07.mp3"},
                new Step{TimeDo = "0",Image="Assets/a6w/1_3.png",Cycle = "6/6",MusicUrl="ms-appx:///Assets/a6w/down.mp3"},
                new Step{TimeDo = "0"},
            #endregion
            };

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Stop();
        }

         void dispatcherTimer_Tick(object sender, object e)
        {
            Parallel.Invoke(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Steps[index].MusicUrl != null)
                    {
                        switch(Steps[index].MusicUrl)
                        {
                            case "ms-appx:///Assets/a6w/up.mp3":
                                if(mediaPlayerUp.Source == null)
                                {
                                    mediaPlayerUp.AutoPlay = false;
                                    mediaPlayerUp.Source = new Uri("ms-appx:///Assets/a6w/up.mp3", UriKind.Absolute);
                                    mediaPlayerUp.AutoPlay = true;
                                }
                                mediaPlayerUp.Play();
                                break;
                            case "ms-appx:///Assets/a6w/down.mp3":
                                if (mediaPlayerDown.Source == null)
                                {
                                    mediaPlayerDown.AutoPlay = false;
                                    mediaPlayerDown.Source = new Uri("ms-appx:///Assets/a6w/down.mp3", UriKind.Absolute);
                                    mediaPlayerDown.AutoPlay = true;
                                }
                                mediaPlayerDown.Play();
                                break;
                            case "ms-appx:///Assets/a6w/switch.mp3":
                                if (mediaPlayerSwitch.Source == null)
                                {
                                    mediaPlayerSwitch.AutoPlay = false;
                                    mediaPlayerSwitch.Source = new Uri("ms-appx:///Assets/a6w/switch.mp3", UriKind.Absolute);
                                    mediaPlayerSwitch.AutoPlay = true;
                                }
                                mediaPlayerSwitch.Play();
                                break;
                            case "ms-appx:///Assets/a6w/beep-07.mp3":
                                if (mediaPlayerBeep.Source == null)
                                {
                                    mediaPlayerBeep.AutoPlay = false;
                                    mediaPlayerBeep.Source = new Uri("ms-appx:///Assets/a6w/beep-07.mp3", UriKind.Absolute);
                                    mediaPlayerBeep.AutoPlay = true;
                                }
                                mediaPlayerBeep.Play();
                                break;
                            case "ms-appx:///Assets/a6w/get ready.mp3":
                                if (mediaPlayerReady.Source == null)
                                {
                                    mediaPlayerReady.AutoPlay = false;
                                    mediaPlayerReady.Source = new Uri("ms-appx:///Assets/a6w/get ready.mp3", UriKind.Absolute);
                                    mediaPlayerReady.AutoPlay = true;
                                }
                                mediaPlayerReady.Play();
                                break;
                            case "ms-appx:///Assets/a6w/1.mp3":
                                if (mediaPlayerOne.Source == null)
                                {
                                    mediaPlayerOne.AutoPlay = false;
                                    mediaPlayerOne.Source = new Uri("ms-appx:///Assets/a6w/1.mp3", UriKind.Absolute);
                                    mediaPlayerOne.AutoPlay = true;
                                }
                                mediaPlayerOne.Play();
                                break;
                            case "ms-appx:///Assets/a6w/2.mp3":
                                if (mediaPlayerTwo.Source == null)
                                {
                                    mediaPlayerTwo.AutoPlay = false;
                                    mediaPlayerTwo.Source = new Uri("ms-appx:///Assets/a6w/2.mp3", UriKind.Absolute);
                                    mediaPlayerTwo.AutoPlay = true;
                                }
                                mediaPlayerTwo.Play();
                                break;
                            case "ms-appx:///Assets/a6w/3.mp3":
                                if (mediaPlayerThree.Source == null)
                                {
                                    mediaPlayerThree.AutoPlay = false;
                                    mediaPlayerThree.Source = new Uri("ms-appx:///Assets/a6w/3.mp3", UriKind.Absolute);
                                    mediaPlayerThree.AutoPlay = true;
                                }
                                mediaPlayerThree.Play();
                                break;
                            case "ms-appx:///Assets/a6w/4.mp3":
                                if (mediaPlayerFour.Source == null)
                                {
                                    mediaPlayerFour.AutoPlay = false;
                                    mediaPlayerFour.Source = new Uri("ms-appx:///Assets/a6w/4.mp3", UriKind.Absolute);
                                    mediaPlayerFour.AutoPlay = true;
                                }
                                mediaPlayerFour.Play();
                                break;
                            case "ms-appx:///Assets/a6w/5.mp3":
                                if (mediaPlayerFive.Source == null)
                                {
                                    mediaPlayerFive.AutoPlay = false;
                                    mediaPlayerFive.Source = new Uri("ms-appx:///Assets/a6w/5.mp3", UriKind.Absolute);
                                    mediaPlayerFive.AutoPlay = true;
                                }
                                mediaPlayerFive.Play();
                                break;
                            case "ms-appx:///Assets/a6w/go.mp3":
                                if (mediaPlayerGo.Source == null)
                                {
                                    mediaPlayerGo.AutoPlay = false;
                                    mediaPlayerGo.Source = new Uri("ms-appx:///Assets/a6w/go.mp3", UriKind.Absolute);
                                    mediaPlayerGo.AutoPlay = true;
                                }
                                mediaPlayerGo.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex1.mp3":
                                if (mediaPlayerEx1.Source == null)
                                {
                                    mediaPlayerEx1.AutoPlay = false;
                                    mediaPlayerEx1.Source = new Uri("ms-appx:///Assets/a6w/ex1.mp3", UriKind.Absolute);
                                    mediaPlayerEx1.AutoPlay = true;
                                }
                                mediaPlayerEx1.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex2.mp3":
                                if (mediaPlayerEx2.Source == null)
                                {
                                    mediaPlayerEx2.AutoPlay = false;
                                    mediaPlayerEx2.Source = new Uri("ms-appx:///Assets/a6w/ex2.mp3", UriKind.Absolute);
                                    mediaPlayerEx2.AutoPlay = true;
                                }
                                mediaPlayerEx2.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex3.mp3":
                                if (mediaPlayerEx3.Source == null)
                                {
                                    mediaPlayerEx3.AutoPlay = false;
                                    mediaPlayerEx3.Source = new Uri("ms-appx:///Assets/a6w/ex3.mp3", UriKind.Absolute);
                                    mediaPlayerEx3.AutoPlay = true;
                                }
                                mediaPlayerEx3.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex4.mp3":
                                if (mediaPlayerEx4.Source == null)
                                {
                                    mediaPlayerEx4.AutoPlay = false;
                                    mediaPlayerEx4.Source = new Uri("ms-appx:///Assets/a6w/ex4.mp3", UriKind.Absolute);
                                    mediaPlayerEx4.AutoPlay = true;
                                }
                                mediaPlayerEx4.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex5.mp3":
                                if (mediaPlayerEx5.Source == null)
                                {
                                    mediaPlayerEx5.AutoPlay = false;
                                    mediaPlayerEx5.Source = new Uri("ms-appx:///Assets/a6w/ex5.mp3", UriKind.Absolute);
                                    mediaPlayerEx5.AutoPlay = true;
                                }
                                mediaPlayerEx5.Play();
                                break;
                            case "ms-appx:///Assets/a6w/ex6.mp3":
                                if (mediaPlayerEx6.Source == null)
                                {
                                    mediaPlayerEx6.AutoPlay = false;
                                    mediaPlayerEx6.Source = new Uri("ms-appx:///Assets/a6w/ex6.mp3", UriKind.Absolute);
                                    mediaPlayerEx6.AutoPlay = true;
                                }
                                mediaPlayerEx6.Play();
                                break;
                        }
                        
                    }

                });
            });

            Parallel.Invoke(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Steps[index].TimeDo != null)
                        this.tbkTGThucHien.Text = Steps[index].TimeDo.ToString();
                });
                
            });

            Parallel.Invoke(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Steps[index].Cycle != null)
                        this.tbkSoBuoc.Text = Steps[index].Cycle;
                });

            });

            Parallel.Invoke(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Steps[index].BaiTap != null)
                        this.tbkBaiTap.Text = Steps[index].BaiTap;
                });

            });
            Parallel.Invoke(async () =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (Steps[index].Image != null)
                    this.imgTuThe.Source = new BitmapImage(new Uri("ms-appx:///" + Steps[index].Image, UriKind.Absolute));

                });

            });

            if (index == (Steps.Count - 1))
                dispatcherTimer.Stop();
            else
                index++;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void brdGo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            dispatcherTimer.Start();
            brdGo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            brdPause.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void brdPause_Tapped(object sender, TappedRoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            brdPause.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            brdGo.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(aboutus));
        }
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(howto));
        }
    }
}

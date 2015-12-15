using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace East_United_Soccer_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> _clubDesc;
        public MainPage()
        {
            this.InitializeComponent();
            setupListsOfDescription();
            pvtOptions.SelectedIndex = 1;
        }
        private void setupListsOfDescription()
        {
            if (_clubDesc != null)
            {
                return;
            }
            _clubDesc = new List<string>();

            _clubDesc.Add("For information about joing the club please contact Pa Spelman on 086083234.\n"
                + "To contact the club on Facebook please click the link here https://www.facebook.com/eastunited.fc?fref=ts \n"
                + " If you have any issues with this application please email eastunitedapp@gmail.com and specify your issue.");
            _clubDesc.Add("Date        Home Team    Away Team           Venue\n"
                + "==================================\n "
                + " 30/08/15/  Kinvra Utd 3 - 2 East Utd               Kinvara \n"
                + " 20/09/15/  Maree/Oranmore 5 - 0 East Utd    Oranmore \n"
                + " 17/10/15/ East Utd 1 - 1 Knocknacarra           Castlepark \n"
                + " 25/10/15/ Loughrea 3 - 0 East Utd                  Loughrea \n"
                + " 1/11/15/ West Utd 3 - 1 East Utd                    South Park \n"
                + " 7/11/15/ East Utd 3 - 3 St Patricks                  Castlepark \n"
                + " 5/12/15/ East Utd  -  Maree/Oranmore          Castlepark \n"
                + " 13/12/15/ East Utd  -  Kinvara Utd                 Castlepark \n"
                + " 10/01/16/ West Coast Utd  - East Utd            Letterfrack \n"
                + " 23/01/16/ West  Utd  - East Utd                    Castlepark \n"
                + " 14/02/16/ Knocknacarra  - East Utd              Cappagh Park \n"
                + " 5/03/16/ East Utd  - Loughrea                       Castlepark \n"
                + " 13/03/16/ St Patricks  - East Utd                   Caherlistrane \n"
                + " 20/03/16/ Renmore  - East Utd                     Renmore \n"
                + " 2/04/16/ East Utd  - Corofin Utd                  Castlepark \n"
                + " 9/04/16/ East Utd  - West Coast Utd            Castlepark \n"
                + " 24/04/16/ East Utd  -Renmore                     Castlepark \n"
                + " TBC Corofin Utd  - East Utd                          Corofin \n"
                + " TBC East Utd  -  Maree/Oranmore               Castlepark \n");

            _clubDesc.Add("East United football club was founded in 2003 and plays it homes matches in Castlepark. The current club manager for the 2015/2016 season is Ollie Keogh and his two assistant managers are Ruben Cullinane and Steve Adex. \n"
                + "The club currently plays in Western Hygiene divsion one which is the second highest tier of football for junior football in Galway. The club has a very succesful history and is the only club that has went from the bottom divison of junior football in Galway too the top divison in history. \n"
                + "The club play in yellow jerseys with black shorts and black socks.Membership for the year is currently 150 € for the football year and includes club gear.Training is on Monday and Wednesday evenings at 6.30 PM in Castlepark"
                + "The club facilities include a large and spacious clubhouse , a floodlight pitch and home and away dressing rooms and a referees room.");

            _clubDesc.Add("                             Western Hygiene Divison One \n"
                + "                            =============================\n "
                +"  Team               Played          Won             Lost            Drawn           Goal Difference          Points\n"
                 + "_________________________________________________________________________________________________\n"
                + " West Utd                4                   4               0               0                   +14                             12\n"
                 + "_________________________________________________________________________________________________\n"
                + " West Coast Utd      5                   3               1               1                   +3                               10\n"
                 + "_________________________________________________________________________________________________\n"
                + " Loughrea                4                   3               0               1                   +4                               9\n"
                 + "_________________________________________________________________________________________________\n"
                + " St Patricks               4                   2               0               2                   +3                               8\n"
                 + "_________________________________________________________________________________________________\n"
                + " Maree/Oranmore   4                   2               1               1                   +8                               7\n"
                 + "_________________________________________________________________________________________________\n"
                + " Kinvara Utd            6                   2               4               0                   -11                              6\n"
                 + "_________________________________________________________________________________________________\n"
                + " Corofin Utd            4                   1               2               1                    0                                4\n"
                 + "_________________________________________________________________________________________________\n"
                + " Knocknacarra         6                   0               3               3                   -8                                3\n"
                 + "_________________________________________________________________________________________________\n"
                + " Renmore                3                   0               1               2                   -2                                2\n"
                + "_________________________________________________________________________________________________\n"
                + " |East Utd                6                   0               4               2                   -11                               2\n"
                +"_________________________________________________________________________________________________");

            _clubDesc.Add("Please tap or click on images to enlarge them.");

            int i;
            TextBlock curr;
            for (i = 0; i <= 8; i++)
            {
                curr = (TextBlock)pvtOptions.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _clubDesc[i];
                }
            }
        }
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // when the user clicks the image, copy the image to the bigmap
            // and the set the map to visible.
            Image mySmallImg = (Image)sender;
            imgBigImg.Source = mySmallImg.Source;
            imgBigImg.Width = Window.Current.Bounds.Width;
            imgBigImg.Height = Window.Current.Bounds.Height;
            imgBigImg.Visibility = Visibility.Visible;

        }

        private void imgBigImg_Tapped(object sender, TappedRoutedEventArgs e)
        {
            imgBigImg.Source = null;
            imgBigImg.Visibility = Visibility.Collapsed;
        }
    }
}

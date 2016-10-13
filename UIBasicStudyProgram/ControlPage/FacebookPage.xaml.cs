using Microsoft.Toolkit.Uwp.Services.Facebook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UIBasicStudyProgram.ControlPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FacebookPage : Page
    {
        public FacebookPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            FacebookService.Instance.Initialize("889998191132474", FacebookPermissions.PublicProfile | FacebookPermissions.UserPosts | FacebookPermissions.PublishActions | FacebookPermissions.UserPhotos);
            if (await FacebookService.Instance.LoginAsync())
            {
                MyButton.Content = "have logined in";
                MyButton.Background = new SolidColorBrush((Color.FromArgb(255,0,0, 200)));
            }

        }

        private void SinaButton_Click(object sender, RoutedEventArgs e)
        {
           
            //var oauthClient = new WeiboSDKForWinRT.ClientOAuth();
            //oauthClient.BeginOAuth();
            //if (oauthClient.IsAuthorized == false)
            //{

            //}
        }
    }
}

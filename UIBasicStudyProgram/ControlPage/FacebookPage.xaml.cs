using Microsoft.Toolkit.Uwp.Services.Facebook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using WeiboSDKForWinRT;
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
            SdkData.AppKey = "495741593";
            SdkData.AppSecret = "7945cd862162c2565048ff76d7d0af8f";
            SdkData.RedirectUri = "http://www.baidu.com";
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

        private async  void SinaButton_Click(object sender, RoutedEventArgs e)
        {
            var oauthClient = new WeiboSDKForWinRT.ClientOAuth();
            oauthClient.BeginOAuth();
            var client=new HttpClient();
            var response =await client.GetAsync("https://api.weibo.com/oauth2/authorize?client_id=495741593&response_type=code&redirect_uri=http://www.baidu.com&AccessKeyDisplayDismissed=client");
            var testresult =await  response.Content.ReadAsStringAsync();
            var result = testresult.ToString();
            Debug.WriteLine(result);
        }
    }
}

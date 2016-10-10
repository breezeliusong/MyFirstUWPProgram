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
using UIBasicStudyProgram.ControlPage;
using UIBasicStudyProgram.DataModel;
using Windows.UI.Core;
using Windows.UI.Xaml.Media.Animation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UIBasicStudyProgram
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested +=
                App_BackRequested;
            this.DataContext = Books;
        }

        private void App_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) return;
            if(rootFrame.CanGoBack && e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void Hub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        //{

        //}

        //private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    string item = e.ClickedItem.ToString();
        //    switch (item)
        //    {
        //        case "Date":
        //            Frame.Navigate(typeof(SplitViewPage));
        //            break;
        //    }
        //}

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack) this.Frame.GoBack();
        }

        private void GridView_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var item = (Book)e.ClickedItem;
            //MyTextBlock.Text = item.Title;
            switch (item.BookId)
            {
                case 1:
                    Frame.Navigate(typeof(Date), item, new DrillInNavigationTransitionInfo());
                    break;
                case 2:
                    Frame.Navigate(typeof(Animation), item, new DrillInNavigationTransitionInfo());
                    break;
                case 3:
                    Frame.Navigate(typeof(Animation), item, new DrillInNavigationTransitionInfo());
                    break;

            }
        }

        private void Popupbutton_Click(object sender, RoutedEventArgs e)
        {
            if (!StandardPopup.IsOpen) StandardPopup.IsOpen = true;
            ParentedPopup.IsOpen = true;
        }

        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            if (StandardPopup.IsOpen) StandardPopup.IsOpen = false;
        }
    }
}

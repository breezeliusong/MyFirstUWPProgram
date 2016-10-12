using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UIBasicStudyProgram.DataModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class AutoLayoutPage : Page
    {
        private ObservableCollection<MyItems> items;
        public AutoLayoutPage()
        {
            this.InitializeComponent();
            items = new ObservableCollection<MyItems>();
            
        }

        private void HumburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySpliteView.IsPaneOpen = !MySpliteView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (First.IsSelected)
            {
                ItemsManager.GetItems("First", items);
                TitleTextBlock.Text = "First";
            }
            else if (Second.IsSelected)
            {
                ItemsManager.GetItems("Second", items);
                TitleTextBlock.Text = "Second";
            }
            //while using binding in the XMAL ,shoule set this code
                //this.DataContext = items;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            First.IsSelected = true;
        }
    }
}

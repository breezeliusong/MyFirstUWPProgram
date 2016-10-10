using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UIBasicStudyProgram.CustomControl;
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
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UIBasicStudyProgram.ControlPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Animation : Page
    {
        private double leftMargin; 
        public Animation()
        {
            this.InitializeComponent();
        }

        private void ContentHost_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Replace the ContentControl's content with a new Rectangle of a random color.
            Rectangle newItem = new Rectangle();
            Random rand = new Random();
            newItem.Height = 200;
            newItem.Width = 200;
            newItem.Fill = new SolidColorBrush(Color.FromArgb(255,
                 (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));

            ContentHost.Content = newItem;
            ExitStoryboard.Begin();
        }

        private void myRectangle_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            EnterStoryboard.Begin();
        }

        private void myRectangle_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //ExitStoryboard.Begin();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PointerReleasedStoryboard.Begin();
            leftMargin += 20;
            repositionButton.Margin = new Thickness(leftMargin, 0, 0, 0);
            if (rectangles.Items.Count > 0)
            {
                rectangles.Items.RemoveAt(0);
            }
        }

        private void CustomControl1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var customControl = (CustomControl1)sender;
            customControl.textblock = "you are custom control";
        }
    }
}

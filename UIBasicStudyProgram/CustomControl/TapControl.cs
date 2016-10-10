using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace UIBasicStudyProgram.CustomControl
{
    public sealed class TapControl:Control
    {
        public TapControl()
        {
            this.DefaultStyleKey = typeof(TapControl);
        }
        protected override void OnPointerPressed(PointerRoutedEventArgs e)
        {
            this.CapturePointer(e.Pointer);
            VisualStateManager.GoToState(this, "PointerDown", true);
        }
        protected override void OnPointerReleased(PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "PointUp", true);
            this.ReleasePointerCapture(e.Pointer);
        }
    }
}

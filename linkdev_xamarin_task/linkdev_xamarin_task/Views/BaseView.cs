using Xamarin.Forms;

namespace linkdev_xamarin_task.Views
{
    public class BaseView : ContentPage
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            MessagingCenter.Send<BaseView, Size>(this, "sizeChanged", new Size() { Width = width, Height = height });
         

        }
    }
}

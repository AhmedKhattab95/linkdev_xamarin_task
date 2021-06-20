namespace linkdev_xamarin_task.Views
{
    public partial class BlankPage : BaseView
    {
        public BlankPage(string title, string message)
        {
            InitializeComponent();
            Title = title;
            errorMsgLabel.Text = message;
        }
    }
}
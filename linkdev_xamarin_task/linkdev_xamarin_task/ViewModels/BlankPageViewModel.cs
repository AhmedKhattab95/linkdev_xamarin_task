using System;

namespace linkdev_xamarin_task.ViewModels
{
    public class BlankPageViewModel : BaseViewModel
    {
        string count = "";
        public string Count { get => count; set { count = Uri.UnescapeDataString(value ?? string.Empty); OnPropertyChanged(); } }
      

    }
}
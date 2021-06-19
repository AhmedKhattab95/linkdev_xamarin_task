using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace linkdev_xamarin_task.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        string count = "";
        public string Count { get => count; set { count = Uri.UnescapeDataString(value ?? string.Empty); OnPropertyChanged(); } }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
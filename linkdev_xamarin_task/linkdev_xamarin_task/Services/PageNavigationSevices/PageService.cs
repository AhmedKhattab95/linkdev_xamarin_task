using System.Threading.Tasks;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Services.PageNaviagationService
{
    public class PageService : IPageService
    {
        public INavigation Navigation
        {
            get { return Application.Current.MainPage.Navigation; }
        }

        public Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }
        public Task DisplayAlert(string title, string message, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public Task PopAsync()
        {
            return Application.Current.MainPage.Navigation.PopAsync(true);
        }

        public Task PushAsync(Page page)
        {
            return Application.Current.MainPage.Navigation.PushAsync(page, true);
        }
        public Task PushModalAsync(Page page)
        {
            return Application.Current.MainPage.Navigation.PushModalAsync(page, true);
        }
        public Task PopModalAsync()
        {
            return Application.Current.MainPage.Navigation.PopModalAsync(true);
        }

        public Task PushToNewStack()
        {
            return Application.Current.MainPage.Navigation.PopToRootAsync(true);
        }
    }
}

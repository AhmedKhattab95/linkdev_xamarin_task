using System.Threading.Tasks;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Services.PageNaviagationService
{
    public interface IPageService
    {
        INavigation Navigation { get; }
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
        Task DisplayAlert(string title, string message, string cancel);
        Task PopAsync();
        Task PushAsync(Page page);
        Task PushModalAsync(Page page);
        Task PopModalAsync();
        Task PushToNewStack();
    }
        
}

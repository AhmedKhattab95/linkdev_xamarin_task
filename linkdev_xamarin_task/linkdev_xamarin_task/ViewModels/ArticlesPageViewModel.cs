using linkdev_xamarin_task.Models;
using linkdev_xamarin_task.Services.DataServices;
using linkdev_xamarin_task.Services.PageNaviagationService;
using linkdev_xamarin_task.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace linkdev_xamarin_task.ViewModels
{
    public class ArticlesPageViewModel : BaseViewModel
    {

        public Command LoadItemsCommand { get; }
        public Command<Article> ItemTapped { get; }
        private readonly IArticleDataService articleDataService = App.IoCContainer.GetInstance<IArticleDataService>();
        private readonly IPageService pageService = App.IoCContainer.GetInstance<IPageService>();

        public ArticlesPageViewModel()
        {
            Articles = new ObservableCollection<Article>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Article>(OnItemSelected);

        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                // remove empty data design
                HasData = true;
                //check internet
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.None || current == NetworkAccess.Unknown)
                {
                    Connected = false;
                    return;
                }
                Connected = true;

                //download articles then bind them
                Articles.Clear();
                var items = await articleDataService.GetArticles();
                if (items?.Any() == true)
                {
                    foreach (var item in items)
                        Articles.Add(item);
                }
                else
                    HasData = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                HasData = false;
            }
            finally
            {
                IsBusy = false;
                ShowMainUI = Connected && !HasData;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public ObservableCollection<Article> Articles { get; }

        private Article _selectedItem;
        public Article SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(Article item)
        {
            if (item == null)
                return;

            pageService.PushAsync(new ItemDetailPage(item));
        }



    }
}
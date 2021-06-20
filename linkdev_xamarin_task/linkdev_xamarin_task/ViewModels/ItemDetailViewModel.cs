using linkdev_xamarin_task.Models;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace linkdev_xamarin_task.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {

        private Article _article;
        public Article article
        {
            get { return _article; }
            set { SetProperty(ref _article, value); }
        }
        public ICommand OpenWebCommand => new Command(async () => await Browser.OpenAsync(article.url));
      
        public ItemDetailViewModel(Article article)
        {
            this.article = article;
        }



    }
}

using linkdev_xamarin_task.Models;
using linkdev_xamarin_task.ViewModels;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Views
{
    public partial class ItemDetailPage : BaseView
    {

        public ItemDetailPage(Article article)
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel(article);
        }


      
    }
}
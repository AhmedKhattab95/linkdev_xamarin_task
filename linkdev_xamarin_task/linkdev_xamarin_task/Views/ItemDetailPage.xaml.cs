using linkdev_xamarin_task.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
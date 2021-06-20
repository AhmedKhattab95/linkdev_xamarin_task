using linkdev_xamarin_task.ViewModels;
using Xamarin.Forms;

namespace linkdev_xamarin_task.Views
{
    public partial class ArticlesPageView : BaseView
    {
        ArticlesPageViewModel _viewModel;

        public ArticlesPageView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ArticlesPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
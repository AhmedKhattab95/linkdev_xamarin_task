using linkdev_xamarin_task.Controls;
using linkdev_xamarin_task.Resources;
using linkdev_xamarin_task.Views;
using System;
using Xamarin.Forms;

namespace linkdev_xamarin_task
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            _addContentPages();
        }

        private void _addContentPages()
        {
            Items.Add( new ShellContent() { Content = new BlankPage(AppResources.liveChat, AppResources.serviceNotAvilable), Title = AppResources.liveChat , Icon = "live.png" });
            Items.Add( new ShellContent() { Content = new BlankPage(AppResources.gallery, AppResources.noItemsAvilable), Title = AppResources.gallery, Icon = "gallery.png" });
            Items.Add( new ShellContent() { Content = new BlankPage(AppResources.wishList, AppResources.serviceNotAvilable), Title = AppResources.wishList, Icon = "wishlist.png" });
            Items.Add( new ShellContent() { Content = new BlankPage(AppResources.exploreOnlineNews, AppResources.noItemsAvilable), Title = AppResources.exploreOnlineNews, Icon = "onlineNews.png" });
        }
    }
}

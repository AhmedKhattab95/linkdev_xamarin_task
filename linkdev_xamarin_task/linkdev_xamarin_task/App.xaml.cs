using linkdev_xamarin_task.Services;
using SimpleInjector;
using linkdev_xamarin_task.Services.PageNaviagationService;
using Xamarin.Forms;
using linkdev_xamarin_task.Services.DataServices;
using linkdev_xamarin_task.Repositories;

namespace linkdev_xamarin_task
{
    public partial class App : Application
    {
        private static Container ioCContainer = new SimpleInjector.Container();
        public static Container IoCContainer
        {
            get => ioCContainer;
        }

        public App()
        {
            InitializeComponent();
            
            SetupDependancies();
            MainPage = new AppShell();
        }

        private void SetupDependancies()
        {
            DependencyService.Register<MockDataStore>();
            ioCContainer.RegisterSingleton<IPageService, PageService>();
            ioCContainer.RegisterSingleton<IArticleDataService, ArticleDataService>();
            ioCContainer.RegisterSingleton<IArticlesRepository, ArticlesRepository>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

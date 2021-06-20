using linkdev_xamarin_task.Models;
using linkdev_xamarin_task.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Services.DataServices
{
    public class ArticleDataService : IArticleDataService
    {
        private readonly IArticlesRepository ArticlesRepository = App.IoCContainer.GetInstance<IArticlesRepository>();

        public async Task<IEnumerable<Article>> GetArticles()
        {
            var associatedPressArticlesTask = ArticlesRepository.GetArticeFromAssociatedPress();
            var webArticlesTask = ArticlesRepository.GetArticeFromNextWeb();
            await Task.WhenAll(associatedPressArticlesTask, webArticlesTask);
            var associatedPressArticles = await associatedPressArticlesTask;
            var webArticles = await webArticlesTask;
            var result = associatedPressArticles?.articles?.Union(webArticles?.articles);
            return result;
        }

    }
}

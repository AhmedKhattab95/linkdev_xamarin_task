using linkdev_xamarin_task.Models;
using linkdev_xamarin_task.Utils;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Repositories
{
    public class ArticlesRepository : BaseRepository, IArticlesRepository
    {
        public Task<BaseResponse> GetArticeFromAssociatedPress()
        {
            string url = Urls.getArticleUrl("associated-press");
            return GetAsync<BaseResponse>(url);
        }

        public Task<BaseResponse> GetArticeFromNextWeb()
        {
            string url = Urls.getArticleUrl("the-next-web");
            return GetAsync<BaseResponse>(url);
        }
    }
}

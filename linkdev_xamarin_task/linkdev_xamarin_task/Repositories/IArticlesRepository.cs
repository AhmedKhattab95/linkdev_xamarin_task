using linkdev_xamarin_task.Models;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Repositories
{
    public interface IArticlesRepository
    {
        /// <summary>
        /// </summary>
        /// <returns>return Task that will contains list of articles from next web api</returns>
        Task<BaseResponse> GetArticeFromNextWeb();
        /// <summary>
        /// </summary>
        /// <returns>return Task that will contains list of articles from Associated Press api</returns>
        Task<BaseResponse> GetArticeFromAssociatedPress();
    }
}

using linkdev_xamarin_task.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Services.DataServices
{
    public interface IArticleDataService
    {
        /// <summary>
        ///  retunr list of articles that came from 2 places
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Article>> GetArticles();
    
    }
}

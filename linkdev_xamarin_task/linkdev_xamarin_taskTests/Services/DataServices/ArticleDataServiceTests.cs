using linkdev_xamarin_task.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace linkdev_xamarin_task.Services.DataServices.Tests
{
    [TestClass()]
    public class ArticleDataServiceTests
    {
        [TestMethod()]
        public async Task GetArticlesTest()
        {
            ArticleDataService dataService = new ArticleDataService(new ArticlesRepository());
            var result = await dataService.GetArticles();
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.Count() > 0);
        }
    }
}
using System.Collections.Generic;

namespace linkdev_xamarin_task.Models
{
    public class BaseResponse
    {
        public string status { get; set; }
        public string source { get; set; }
        public string sortBy { get; set; }
        public IEnumerable<Article> articles { get; set; }
    }

}



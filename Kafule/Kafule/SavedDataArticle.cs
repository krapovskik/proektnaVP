using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class SavedDataArticle
    {
        public List<Article> articles { get; set; }

        public SavedDataArticle(List<Article> articles)
        {
            this.articles = new List<Article>();
            this.articles.AddRange(articles);
        }
    }
}

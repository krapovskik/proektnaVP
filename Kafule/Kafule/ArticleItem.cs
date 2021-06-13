using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class ArticleItem
    {
        public Article article { get; set; }
        public int quantity { get; set; }
        public bool ordered { get; set; }

        public ArticleItem()
        {
            ordered = false;
        }
    }
}

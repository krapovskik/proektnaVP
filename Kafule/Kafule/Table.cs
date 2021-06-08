using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class Table
    {
        public string Name { get; set; }
        public List<ArticleItem> items { get; set; }

        public Table()
        {
            items = new List<ArticleItem>();
        }

        public override string ToString()
        {
            return String.Format("{1}", Name);
        }
    }
}

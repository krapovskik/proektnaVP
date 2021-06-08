using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class Article
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} денари - {2}",Name,Price,Code);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class User
    {
        public string name { get; set; }
        public string code { get; set; }
        public List<Table> tables { get; set; }

        public User()
        {
            tables = new List<Table>();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}",code, name);
        }
    }
}

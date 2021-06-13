using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class SavedDataTables
    {
        public List<Table> tables { get; set; }

        public SavedDataTables(List<Table> tables)
        {
            this.tables = new List<Table>();
            tables.AddRange(tables);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class Admin
    {
        public string username { get; set; }
        public byte[] password { get; set; }
    }
}

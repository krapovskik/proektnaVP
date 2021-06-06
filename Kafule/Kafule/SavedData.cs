using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    [Serializable]
    public class SavedData
    {
        public Admin admin;
        public List<User> users;
        public Waiter waiter;
        public SavedData(Admin admin,Waiter waiter, List<User> users)
        {
            this.admin = admin;
            this.users = new List<User>();
            this.users.AddRange(users);
            this.waiter = waiter;
        }
    }
}

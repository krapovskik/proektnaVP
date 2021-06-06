using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafule
{
    public class FirstTimeSave
    {
        public static void SaveFirstTime(Admin admin)
        {
            Waiter waiter = new Waiter() { username = "1", password = "1" };
            List<User> users = new List<User>();
            SaveSystem.SaveData(admin, waiter, users);
        }
    }
}

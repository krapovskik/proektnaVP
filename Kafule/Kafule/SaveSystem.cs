using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Kafule
{
    public class SaveSystem
    {
        public static readonly string path = Directory.GetCurrentDirectory()+"/login.cafe";
        public static void SaveData(Admin admin,Waiter waiter,List<User> users)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Create);

            SavedData data = new SavedData(admin,waiter,users);

            formatter.Serialize(stream, data);
            stream.Close();
        }
        public static SavedData LoadData()
        {
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                SavedData data = formatter.Deserialize(stream) as SavedData;
                stream.Close();

                return data;
            }
            else
            {
                return null;
            }
        }
        public static void DeleteData()
        {
            File.Delete(path);
        }
    }
    

    
}

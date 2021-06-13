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
        public static readonly string pathArticle = Directory.GetCurrentDirectory() + "/article.cafe";
        public static readonly string pathTables = Directory.GetCurrentDirectory() + "/tables.cafe";

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

        public static void SaveDataArticle(List<Article> articles)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(pathArticle, FileMode.Create);

            SavedDataArticle data = new SavedDataArticle(articles);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static SavedDataArticle LoadDataArticle()
        {
            if (File.Exists(pathArticle))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(pathArticle, FileMode.Open);

                SavedDataArticle data = formatter.Deserialize(stream) as SavedDataArticle;
                stream.Close();

                return data;
            }
            else
            {
                return null;
            }
        }
        public static void DeleteDataArticle()
        {
            File.Delete(pathArticle);
        }

        public static void SaveDataTables(List<Table> tables)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(pathTables, FileMode.Create);

            SavedDataTables data = new SavedDataTables(tables);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static SavedDataTables LoadDataTables()
        {
            if (File.Exists(pathTables))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(pathArticle, FileMode.Open);

                SavedDataTables data = formatter.Deserialize(stream) as SavedDataTables;
                stream.Close();

                return data;
            }
            else
            {
                return null;
            }
        }
        public static void DeleteDataTables()
        {
            File.Delete(pathTables);
        }
    }
}

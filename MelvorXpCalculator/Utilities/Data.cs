using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MelvorXpCalculator.Utilities
{
    public static class Data
    {
        public static void Store<T>(List<T> data, string filename)
        {
            string serializedData = JsonConvert.SerializeObject(data);
            File.WriteAllText(filename, serializedData);
        }

        public static List<T> Retrieve<T>(string file)
        {
            JArray jsonArray = JArray.Parse(File.ReadAllText(file));
            return jsonArray.ToObject<List<T>>();
        }

        public static Models.Skill RetrieveSkill(string name)
        {
            List<Models.Skill> data = Retrieve<Models.Skill>("Skills.json");
            return data.Find(m => m.Name == name );
        }

        public static List<Models.Item> RetrieveItems(string category)
        {
            List<Models.Item> data = Retrieve<Models.Item>("Items.json");
            return data.FindAll(m => m.Category == category);
        }

        public static List<Models.Item> RetrieveItems(string category, string subcategory)
        {
            List<Models.Item> data = Retrieve<Models.Item>("Items.json");
            return data.FindAll(m => m.Category == category && m.SubCategory == subcategory);
        }
    }
}

using System.Text.Json;
{

}

namespace Repetition_7_5
{
    public class JsonRepository<T> : IRepository<T> where T : IHasId
    {
        private string _filePath;
        private List<T> items;

        public JsonRepository(string filePath)
        {
            _filePath = filePath;
            items = new List<T>();

            Load();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Remove(int id)
        {
            T? item = GetById(id);
            if (item != null)
            {
                items.Remove(item);
                return true;
            }
            return false;
        }

        public T? GetById(int id)
        {
            foreach (T item in items)
            {
                if (item.Id == id)
                    return item;
            }
            return default;
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private void Load()
        {
            if (!File.Exists(_filePath))
            {
                items = new List<T>();
                return;
            }
            try
            {
                string json = File.ReadAllText(_filePath);
                items = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (JsonException e)
            {
                Console.WriteLine("Error when trying to read JSON: " + e.Message);
                items = new List<T>();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while loading data: " + e.Message);
                items = new List<T>();
            }
        }


    }
}

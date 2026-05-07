using System.Text.Json;

namespace Repetition_7_5
{
    public class NoteRepository
    {
        private string filePath = "notes.json";
        private List<Note> notes;

        public NoteRepository()
        {
            notes = new List<Note>();
            Load();
        }

        public void Add(Note note)
        {
            notes.Add(note);
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(notes);
            File.WriteAllText(filePath, json);
        }

        /*public void Load()
        {

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                notes = JsonSerializer.Deserialize<List<Note>>(json);
            }
            else
                notes = new List<Note>();
        }*/

        public void Load()
        {
            if (!File.Exists(filePath))
            {
                notes = new List<Note>();
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);

                notes = JsonSerializer.Deserialize<List<Note>>(json) ?? new List<Note>();
            }
            catch (JsonException e)
            {
                Console.WriteLine("Error when trying to read JSON: " + e.Message);
                notes = new List<Note>();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while loading notes: " + e.Message);
                notes = new List<Note>();
            }
        }

        public List<Note> GetAll()
        {
            return notes;
        }
    }
}

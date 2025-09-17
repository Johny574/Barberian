using System.Text.Json;

public static class Serializer   {
    public static string AppRelativeSavePath { get; private set; } = Directory.GetCurrentDirectory();
    public static void SaveFile<T>(T obj, string filename) {
        var saveSlotDirectory = Path.Join(AppRelativeSavePath, "Save");

        FileWriter.CreateDirectory(saveSlotDirectory);

        FileWriter.CreateFile(Path.Join(saveSlotDirectory, filename));

        using (FileStream filestream = File.Open(Path.Join(saveSlotDirectory, filename), FileMode.Truncate)) {
            using (StreamWriter writer = new StreamWriter(filestream)) {
                string serializedObj = JsonSerializer.Serialize(obj);
                writer.Write(serializedObj);
                writer.Flush();
            }
        }
    }
      
    public static T? LoadFile<T>(string file) {
        var saveSlotDirectory = Path.Join(AppRelativeSavePath, "Save");
        FileWriter.CreateDirectory(saveSlotDirectory);
  
        var saveFilePath = Path.Join(saveSlotDirectory, file);

        if (Path.Exists(saveFilePath))
            return default;

        FileStream fileStream = File.Open(saveFilePath, FileMode.Open);
        using (StreamReader reader = new StreamReader(fileStream)) {
            string json = reader.ReadToEnd(); // Read file contents
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}

public class SerializeException : Exception {
    public SerializeException(string message) : base(message) {

    }
}

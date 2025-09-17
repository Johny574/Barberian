public static class FileWriter {
    public static void CreateFile(string filePath) {
        if (File.Exists(filePath)) {
            return;
        }
        
        var f = File.Create(filePath);
        f.Close();
    }

    public static void CreateDirectory(string directoryPath) {
        if (Directory.Exists(directoryPath)) {
            return;
        }

        Directory.CreateDirectory(directoryPath);
    }
}

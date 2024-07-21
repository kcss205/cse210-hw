using System;
    public class FileManager
    {
        public static void SaveData(string filePath, string data)
        {
            File.WriteAllText(filePath, data);
        }

        public static string LoadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
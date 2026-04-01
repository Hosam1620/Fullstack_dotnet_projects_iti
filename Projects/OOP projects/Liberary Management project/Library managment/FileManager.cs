using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Library_managment
{
    internal class FileManager
    {
       public static void Save<T>(string filePath,List<T> data) 
        {
            
            string json=JsonSerializer.Serialize(data);
            File.WriteAllText(filePath,json);
        
        }
        public static List<T> Load<T>(string filePath)
        {
           
                if (!File.Exists(filePath))
                    return new List<T>();

                string json = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<List<T>>(json)
                       ?? new List<T>();
        }
        
    }
}

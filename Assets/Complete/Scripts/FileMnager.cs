using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Complete {
    public static class FileMnager {
        public static bool FileExist(string fileName) {
            var path = string.Format(@"{0}/{1}.dat", Application.persistentDataPath, fileName);
            return File.Exists(path);
        }

        public static T LoadData<T>(string fileName) {
            var formatter = new BinaryFormatter();
            var path = GetPathToFile(fileName);
            using (var fileStream = File.Open(path, FileMode.Open)) {
                return (T) formatter.Deserialize(fileStream);
            }
        }

        public static void SaveData<T>(string fileName, T data) {
            var formatter = new BinaryFormatter();
            var path = GetPathToFile(fileName);
            using (var fileStream = File.Create(path)) {
               formatter.Serialize(fileStream, data);
            }
        }

        private static string GetPathToFile(string fileName) {
            return string.Format(@"{0}/{1}.dat", Application.persistentDataPath, fileName);
        }
    }
}

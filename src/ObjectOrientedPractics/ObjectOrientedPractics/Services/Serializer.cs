using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы для сериализации и десериализации объектов.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// путь сохранения данных
        /// </summary>
        private static string Path = @"..\..\Data\";

        /// <summary>
        /// Проверяет, существует ли файл.
        /// </summary>
        /// <param name="nameFile"></param>
        /// <returns></returns>
        public static bool IsFile(string nameFile)
        {
            return File.Exists(Path + nameFile);          
        }       

        /// <summary>
        /// Сохраняет объекты из списка в формате JSON.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="nameFile">Имя файла для сохранения.</param>
        /// <param name="listObjects">Список объектов.</param>
        public static void SaveToFile<T>(string nameFile, List<T> listObjects)
        {
            if (listObjects.Count == 0)
            {
                File.Delete(Path + nameFile);

                return;
            }
            
            using (StreamWriter writer = new StreamWriter(Path + nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(listObjects));
            }
        }

        /// <summary>
        /// Загружает объекты в формате JSON и десериализует их в список.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="nameFile">Имя файла для загрузки объектов.</param>
        /// <returns></returns>
        public static List<T> LoadFromFile<T>(string nameFile)
        {
            var listObjects = new List<T>();

            using (StreamReader reader = new StreamReader(Path + nameFile))
            {
                listObjects = JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
            }

            return listObjects;
        }
    }
}

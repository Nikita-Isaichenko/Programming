using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace ListOfStudents.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации данных
    /// </summary>
    public static class Serializer
    {      
        /// <summary>
        /// Создает экземпляр класса <see cref="Serializer"/>
        /// </summary>
        static Serializer()
        {
            Path = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}" +
                    @"\Isaichenko Nikita\List of Students\";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                DirectoryInfo directory = Directory.CreateDirectory(Path);
            }
        }
        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }
        
        /// <summary>
        /// Сохраняет данные из списка в формате JSON.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        public static void SaveToFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {

                writer.Write(JsonConvert.SerializeObject(students));
            }
        }

        /// <summary>
        /// Загружает данные в формате JSON и десериализует их в список.
        /// </summary>
        /// <returns>Список объектов <see cref="Student"/>.</returns>
        public static List<Student> LoadFromFile()
        {          
            {
                var students = new List<Student>();

                try
                {
                    using (StreamReader reader = new StreamReader(Path + FileName))
                    {
                        students = JsonConvert.DeserializeObject<List<Student>>(reader.ReadToEnd());
                    }

                    if (students == null) students = new List<Student>();
                }
                catch
                {
                    return students;
                }

                return students;
            }
        }        
    }
}

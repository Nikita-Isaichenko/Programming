using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ListOfStudents.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации данных
    /// </summary>
    public static class Serializer
    {
        public static string Path { get; set; }

        public static void SaveToFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(Path))
            {

                writer.Write(JsonConvert.SerializeObject(students));
            }
        }

        public static List<Student> LoadFromFile()
        {          
            {
                var students = new List<Student>();

                try
                {
                    using (StreamReader reader = new StreamReader(Path))
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

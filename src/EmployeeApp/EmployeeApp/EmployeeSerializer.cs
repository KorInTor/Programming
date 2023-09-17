using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace EmployeeApp
{
    /// <summary>
    /// Предоставляет методы для сериализации данных.
    /// </summary>
    public static class EmployeeSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string Filename { get; set; }


        /// <summary>
        /// Проверяет, существует ли папка, указанная в свойстве Filename.
        /// И, если папка не существует, то создает папку.
        /// </summary>
        public static void CreateDirectory()
        {
            if (!Directory.Exists(Filename))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Filename));
            }
        }

        /// <summary>
        /// Сохраняет данные о сотрудниках в файл.
        /// </summary>
        /// <param name="employee">Список сотрудников, которые нужно сохранить.</param>
        /// <exception cref="Exception">Возникает, 
        /// если произошла ошибка при сохранении.</exception>
        public static void SaveToFile(List<Employee> employee)
        {
            try
            {
                CreateDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, employee);
                }
            }
            catch
            {
                throw new Exception($"An error occurred while saving data to a file.");
            }
        }

        /// <summary>
        /// Возвращает данные о сотрудниках загруженных из файла <see cref="FileName"/>.
        /// </summary>
        /// <returns> Возвращает список считанных значение, если считать не удалось возвращает пустой список.</returns>
        public static List<Employee> LoadFromFile()
        {
            List<Employee> employee = null;
            try
            {
                CreateDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    employee = serializer.Deserialize<List<Employee>>(reader);
                }
            }
            catch
            {
                return new List<Employee>();
            }
            return employee;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="EmployeeSerializer"/> 
        /// и задаёт для <see cref="Filename"/> путь до appdata.
        /// </summary>
        static EmployeeSerializer()
        {
            Filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Pryakhin\EmployeeApp\userdata.json";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace ContactsApp
{
    /// <summary>
    /// Статический класс для сохранения и выгрузки из файла
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Поле хранит путь до файла
        /// </summary>
        public static string Path { get; set; } = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\Komkov\ContactsApp\";

        public static string FileName { get; set; } = @"Contacts.txt";
        /// <summary>
        /// статический метод сохраняет список контактов в файл
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void Save(Project data, string filePath)
        {
            var directoryPath = System.IO.Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(directoryPath + FileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// статический метод загружает список контактов из файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Project Load(string filePath)
        {
            var directoryPath = System.IO.Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (!directoryInfo.Exists)
            {
                return new Project();
            }

            if (!File.Exists(directoryPath + FileName))
            {
                return new Project();
            }


            //Создаём переменную, в которую поместим результат десериализации
            Project project = new Project();
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(directoryPath + FileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = (Project)serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}

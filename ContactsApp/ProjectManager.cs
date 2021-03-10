﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace ContactsApp
{
    public static class ProjectManager
    {
        public static string PathToFile = @"G:\json.txt";



        /* public static void SaveToFile(<type> data, string filename);
         public static <type> LoadFromFile(string filename);*/
        public static void SaveToFile(Project data, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static Project LoadFromFile(string filename)
        {

            //Создаём переменную, в которую поместим результат десериализации
            Project project = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = (Project)serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}

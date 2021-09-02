using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        /// <summary>
        /// Путь к файлу, из которой загружается сборка
        /// </summary>
        private static readonly string LocalPath = Assembly.GetExecutingAssembly().Location;

        /// <summary>
        /// Переменная, хранящая папку, в которой лежит файл сборки
        /// </summary>
        private static readonly string PathDirectoryName = Path.GetDirectoryName(LocalPath);

        /// <summary>
        /// Путь к правильному файлу
        /// </summary>
        private readonly string _correctProjectFileName = PathDirectoryName +  @"\TestData\correct.txt";

        /// <summary>
        /// Путь к поврежденному файлу
        /// </summary>
        private readonly string _corruptedProjectFileName = PathDirectoryName + @"\TestData\corrupted.txt";

        /// <summary>
        /// Путь к папке для сохранения файла
        /// </summary>
        private static readonly string _outputFilePath = PathDirectoryName + @"\Output";

        /// <summary>
        /// Путь для сохранения файла
        /// </summary>
        private readonly string _outputProjectFileName = _outputFilePath + @"\Contacts.txt";

        private Project GetCorrectProject()
        {
            var correctProject = new Project();
            correctProject.Сontacts.Add(new Contact()
            {
                BirthDate = new DateTime(1900, 1, 1),
                IdVkontakte = "13560",
                Name = "Peter",
                Surname = "Petrov",
                Email = "ptr@mail.ru",
                PhoneNumber = new PhoneNumber("7","999","1234567",PhoneType.Mobile)
            });
            correctProject.Сontacts.Add(new Contact()
            {
                BirthDate = new DateTime(1900, 1, 1),
                IdVkontakte = "14460",
                Name = "Ivan",
                Surname = "Petrov",
                Email = "ivn@mail.ru",
                PhoneNumber = new PhoneNumber("7", "888", "3214567", PhoneType.Mobile)
            });

            return correctProject;
        }

        [Test(Description = "Позитивный тест сериализации проекта")]
        public void SaveToFile_SaveCorrectProject_ProjectSavedCorrectly()
        {
            //Setup
            var savingProject = GetCorrectProject();
            var path = _outputFilePath;
            if (File.Exists(_outputFilePath))
            {
                Directory.Delete(_outputFilePath, true);
            }

            //Act
            ProjectManager.Save(savingProject, path + @"\Contacts.txt");

            //Assert
            var actual = File.ReadAllText(_outputProjectFileName);
            var expected = File.ReadAllText(_correctProjectFileName);
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест десериализации проекта")]
        public void LoadFromFile_LoadCorrectProject_ProjectLoadedCorrectly()
        {
            //Setup
            var expectedProject = GetCorrectProject();

            //Act
            var actualProject = ProjectManager.Load(_correctProjectFileName);

            //Assert
            Assert.AreEqual(expectedProject.Сontacts.Count, actualProject.Сontacts.Count);
            Assert.Multiple(() =>
            {
                for(var i=0; i < expectedProject.Сontacts.Count; i++)
                {
                    var expected = expectedProject.Сontacts[i];
                    var actual = actualProject.Сontacts[i];
                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [Test(Description = "Тест десериализации поврежденного файла")]
        public void LoadFromFile_LoadNotCorrectProject_ProjectLoadedNotCorrectly()
        {
            //Act
            var actualProject = ProjectManager.Load(_corruptedProjectFileName);
            //Assert
            Assert.AreEqual(actualProject.Сontacts.Count, 0);
            Assert.NotNull(actualProject);
        }

        [Test(Description = "Тест десериализации несуществующего файла")]
        public void LoadFromFile_LoadNonExistentProject_ProjectLoadedNotCorrectly()
        {
            //Act
            var actualProject = ProjectManager.Load(@"\TestData\Project.json");
            //Assert
            Assert.AreEqual(actualProject.Сontacts.Count, 0);
            Assert.NotNull(actualProject);
        }
    }
}

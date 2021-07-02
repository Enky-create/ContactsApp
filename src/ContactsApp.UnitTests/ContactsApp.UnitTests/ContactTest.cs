using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Определение классов юнит-тестирования
    /// </summary>
    [TestFixture]
    class ContactTest
    {
        /// <summary>
        /// Метод, выполняющийся каждый раз перед запуском теста
        /// Создает экземпляр номера контакта
        /// </summary>
        public Contact GetContact()
        {
            var contact = new Contact();
            return contact;
        }

        [Test(Description = "Позитивный тест геттера BirthDate")]
        public void BirthDate_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.BirthDate = new DateTime(2000, 1, 1);
            var expected = new DateTime(2000, 1, 1);
            var actual = sourceContact.BirthDate;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера BirthDate")]
        public void BirthDate_SetCorrectValue()
        {
            var sourceContact = GetContact();
            var expected = new DateTime(2000, 1, 1);
            sourceContact.BirthDate = expected;
            var actual = sourceContact.BirthDate;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера BirthDate")]
        public void BirthDate_SetTooEarlyDate()
        {
            var sourceContact = GetContact();
            var actual = " ";
            var expected = "The date cannot be greater than the current one and less than 1.01.1900";
            try
            {
                sourceContact.BirthDate = new DateTime(1000, 1, 1);
            }
            catch(ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера BirthDate")]
        public void BirthDate_SetTooLateDate()
        {
            var sourceContact = GetContact();
            var actual = " ";
            var expected = "The date cannot be greater than the current one and less than 1.01.1900";
            try
            {
                sourceContact.BirthDate = new DateTime(3000, 1, 1);
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера IdVkontakte")]
        public void IdVkontakte_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.IdVkontakte = "111";
            var expected = "111";
            var actual = sourceContact.IdVkontakte;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера IdVkontakte")]
        public void IdVkontakte_SetCorrectValue()
        {
            var sourceContact = GetContact();
            var expected = "111";
            sourceContact.IdVkontakte = expected;
            var actual = sourceContact.IdVkontakte;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера IdVkontakte")]
        public void IdVkontakte_SetTooLongValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "IdVkontakte is greater than 15 characters";
            try
            {
                sourceContact.IdVkontakte = "11111111111111111111111111111111111111111";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void Name_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.Name = "111";
            var expected = "111";
            var actual = sourceContact.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера Name")]
        public void Name_SetCorrectValue()
        {
            var sourceContact = GetContact();
            var expected = "111";
            sourceContact.Name = expected;
            var actual = sourceContact.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера Name пустая строка")]
        public void Name_SetEmptyValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "Length of name 0 name must be greater";
            try
            {
                sourceContact.Name = "";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера Name")]
        public void Name_SetTooLongValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "Name is more than 50 characters";
            try
            {
                sourceContact.Name = "555555555555555555555555555555555555555555555555" +
                    "555555555555555555555555555555555555555";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Surname")]
        public void Surname_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.Surname = "111";
            var expected = "111";
            var actual = sourceContact.Surname;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера Surname")]
        public void Surname_SetCorrectValue()
        {
            var sourceContact = GetContact();
            var expected = "111";
            sourceContact.Surname = expected;
            var actual = sourceContact.Surname;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера Surname")]
        public void Surname_SetTooLongValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "Last name is more than 50 characters";
            try
            {
                sourceContact.Surname = "555555555555555555555555555555555555555555555555" +
                    "555555555555555555555555555555555555555";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера Surname пустая строка")]
        public void Surname_SetEmptyValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "The length of the surname is "
                        + "".Length
                        + "surname must be greater than 0";
            try
            {
                sourceContact.Surname = "";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void Email_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.Email = "111";
            var expected = "111";
            var actual = sourceContact.Email;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера Email")]
        public void Email_SetCorrectValue()
        {
            var sourceContact = GetContact();
            var expected = "111";
            sourceContact.Email = expected;
            var actual = sourceContact.Email;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера Email")]
        public void Email_SetTooLongValue()
        {
            var sourceContact = GetContact();
            var actual = "";
            var expected = "Email more than 50 characters";
            try
            {
                sourceContact.Email = "555555555555555555555555555555555555555555555555" +
                    "555555555555555555555555555555555555555";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Contact")]
        public void Contact_GetPhoneNumber()
        {
            var sourceContact = GetContact();
            var phone = new PhoneNumber("7", "952", "8965112");
            sourceContact.PhoneNumber = phone;
            var expected = phone;
            var actual = sourceContact.PhoneNumber;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест cеттера Contact")]
        public void Contact_SetPhoneNumber()
        {
            var sourceContact = GetContact();
            var phone = new PhoneNumber("7", "952", "8965112");
            var expected = phone;

            sourceContact.PhoneNumber = expected;
            var actual = sourceContact.PhoneNumber;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера GetNumber")]
        public void GetNumber_GetEmptyValue()
        {
            var sourceContact = GetContact();
            var expected = "79991234567";
            var actual = sourceContact.GetNumber();
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера GetNumber")]
        public void GetNumber_GetCorrectValue()
        {
            var sourceContact = GetContact();
            sourceContact.PhoneNumber = new PhoneNumber("7", "888", "8975110");
            var expected = "78888975110";
            var actual = sourceContact.GetNumber();
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест Contact()")]
        public void ContactConstructor()
        {
            var contact = new Contact();
        }

        [Test(Description = "Тест конструктор Contact с параметрами")]
        public void ContactConstructorWithValues()
        {
            var expected = new Contact();
            var phone = new PhoneNumber();
            var actual = new Contact(phone, "vadim", "komkov", new DateTime(1998,10,23),"kom@mail","11122");
            expected.PhoneNumber = phone;
            expected.Name = "vadim";
            expected.Surname = "komkov";
            expected.BirthDate = new DateTime(1998, 10, 23);
            expected.Email = "kom@mail";
            expected.IdVkontakte = "11122";
            Assert.AreEqual(expected.PhoneNumber, actual.PhoneNumber);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Surname, actual.Surname);
            Assert.AreEqual(expected.BirthDate, actual.BirthDate);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.IdVkontakte, actual.IdVkontakte);
        }

        [Test(Description = "Тест клонирования ICloneable")]
        public void TestClone_ReturnsSameClone()
        {
            //Act
            var contact = new Contact(new PhoneNumber(), "vadim", "komkov", new DateTime(1998, 10, 23), "kom@mail", "11122");
               
            var clone = (Contact)contact.Clone();

            //Assert
            Assert.AreEqual(clone.BirthDate, contact.BirthDate);
            Assert.AreEqual(clone.Name, contact.Name);
            Assert.AreEqual(clone.Surname, contact.Surname);
            Assert.AreEqual(clone.PhoneNumber.CountryCode, contact.PhoneNumber.CountryCode);
            Assert.AreEqual(clone.PhoneNumber.CityCode, contact.PhoneNumber.CityCode);
            Assert.AreEqual(clone.PhoneNumber.SubscriberCode, contact.PhoneNumber.SubscriberCode);
            Assert.AreEqual(clone.PhoneNumber.Type, contact.PhoneNumber.Type);
            Assert.AreEqual(clone.Email, contact.Email);
            Assert.AreEqual(clone.IdVkontakte, contact.IdVkontakte);
        }
    }
}

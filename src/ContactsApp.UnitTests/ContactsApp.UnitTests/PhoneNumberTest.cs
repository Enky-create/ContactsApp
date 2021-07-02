using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Определение классов юнит-тестирования
    /// </summary>
    [TestFixture]
    public class PhoneNumberTest
    {
        /// <summary>
        /// Метод, выполняющийся каждый раз перед запуском теста
        /// Создает экземпляр номера телефона
        /// </summary>
        public PhoneNumber GetPhone()
        {
            var phone = new PhoneNumber();
            return phone;
        }

        [Test(Description = "Позитивный тест cеттера CountryCode")]
        public void CountryCode_SetCorrectValue()
        {
            var sourcePhone = GetPhone();
            var expected = "7";
            sourcePhone.CountryCode = expected;
            var actual = sourcePhone.CountryCode;
            Assert.AreEqual(expected, actual);
        }
        
        [Test(Description = "Негативный тест cеттера CountryCode содержится буква")]
        public void CountryCode_SetSymbolsValue()
        {
            var sourcePhone = GetPhone();
            var expected = "The number contains symbols other than numbers";
            var actual = "";
            try
            {
                sourcePhone.CountryCode = "fff7";
            }
            catch(ArgumentException exception)
            {
                 actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера CountryCode код не равен 7")]
        public void CountryCode_SetUncorrectValue()
        {
            var sourcePhone = GetPhone();
            var expected = "Country code must be 7";
            var actual = "";
            try
            {
                sourcePhone.CountryCode = "8";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера CountryCode")]
        public void CountryCode_GetCorrectValue()
        {
            var sourcePhone = GetPhone();
            sourcePhone.CountryCode = "7";
            var expected = "7";
            var actual = sourcePhone.CountryCode;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера CityCode")]
        public void CityCode_GetCorrectValue()
        {
            var sourcePhone = GetPhone();
            sourcePhone.CityCode = "888";
            var expected = "888";
            var actual = sourcePhone.CityCode;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера CityCode")]
        public void CityCode_SetCorrectValue()
        {
            var sourcePhone = GetPhone();
            var expected = "777";
            sourcePhone.CityCode = expected;
            var actual = sourcePhone.CityCode;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера CityCode слишком длинное значение")]
        public void CityCode_SetTooLongValue()
        {
            var actual = "";
            var sourcePhone = GetPhone();
            var expected = "Insufficient length of the area code, it must be equal to 3";
            try
            {
                sourcePhone.CityCode = "666666";
            }
            catch(ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера CityCode слишком короткое значение / пустая строка")]
        public void CityCode_SetTooShortValue()
        {
            var actual = "";
            var sourcePhone = GetPhone();
            var expected = "Insufficient length of the area code, it must be equal to 3";
            try
            {
                sourcePhone.CityCode = "";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }
        
        [Test(Description = "Позитивный тест геттера SubscriberCode")]
        public void SubscriberCode_GetValue()
        {
            var sourcePhone = GetPhone();
            sourcePhone.SubscriberCode = "7777777";
            var expected = "7777777";
            var actual = sourcePhone.SubscriberCode;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера SubscriberCode слишком короткое значение / пустая строка")]
        public void SubscriberCode_SetTooShortValue()
        {
            var actual = "";
            var sourcePhone = GetPhone();
            var expected = "Insufficient length of the subscriber number, the length must be7";
            try
            {
                sourcePhone.SubscriberCode = "";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера SubscriberCode")]
        public void SubscriberCode_SetCorrectValue()
        {
            var sourcePhone = GetPhone();
            var expected = "1234567";
            sourcePhone.SubscriberCode = expected;
            var actual = sourcePhone.SubscriberCode;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Type")]
        public void Type_SetCorrectValue()
        {
            var sourcePhone = GetPhone();
            var expected = PhoneType.Home;
            sourcePhone.Type = expected;
            var actual = sourcePhone.Type;
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Негативный тест cеттера SubscriberCode слишком длинное  значение")]
        public void SubscriberCode_SetLongShortValue()
        {
            var actual = "";
            var sourcePhone = GetPhone();
            var expected = "Insufficient length of the subscriber number, the length must be7";
            try
            {
                sourcePhone.SubscriberCode = "111111111111111111111111111";
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест PhoneNumber()")]
        public void PhoneNumberConstructor()
        {
            var phone = new PhoneNumber();
        }

        [Test(Description = "Тест public PhoneNumber(string countryCode, string cityCode, string subscriberCode, PhoneType type)")]
        public void PhoneNumberConstructorWithValues()
        {
            var expected = new PhoneNumber();
            var actual = new PhoneNumber("7","999","1234567", PhoneType.Home);
            expected.CountryCode = "7";
            expected.CityCode = "999";
            expected.SubscriberCode = "1234567";
            expected.Type = PhoneType.Home;
            Assert.AreEqual(expected.CountryCode, actual.CountryCode);
            Assert.AreEqual(expected.CityCode, actual.CityCode);
            Assert.AreEqual(expected.SubscriberCode, actual.SubscriberCode);
            Assert.AreEqual(expected.Type, actual.Type);
        }

        [Test(Description = "Тест public PhoneNumber(string countryCode, string cityCode, string subscriberCode)")]
        public void PhoneNumberConstructorWithoutType()
        {
            var expected = new PhoneNumber();
            var actual = new PhoneNumber("7", "999", "1234567");
            expected.CountryCode = "7";
            expected.CityCode = "999";
            expected.SubscriberCode = "1234567";
            Assert.AreEqual(expected.CountryCode, actual.CountryCode);
            Assert.AreEqual(expected.CityCode, actual.CityCode);
            Assert.AreEqual(expected.SubscriberCode, actual.SubscriberCode);
        }


    }
}

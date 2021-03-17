using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс номер телефона : Код страны, код города, номер абонента.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Константа для проверки на российские номера
        /// </summary>
        private const string RussianCountryCode = "7";

        /// <summary>
        /// Константа хранит длину кода города
        /// </summary>
        private const int CityCodeLength = 3;

        /// <summary>
        /// Константа хранит длину номера абонента
        /// </summary>
        private const int SubscriberCodeLength = 7; 

        /// <summary>
        /// Строка хранящая код страны
        /// </summary>
        private  string _countryCode;

        /// <summary>
        /// Строка хранящая код города
        /// </summary>
        private string _cityCode;

        /// <summary>
        /// Строка хранящая код абонента
        /// </summary>
        private string _subscriberCode;

        /// <summary>
        /// Свойство с проверкой на российский номер
        /// </summary>
        public string CountryCode 
        {
            set 
            {
              
                if (string.Compare(RussianCountryCode, value) != 0)
                {
                    throw new ArgumentException("Не российский код страны");
                }
                _countryCode = value;
            }

            get 
            {
                return this._countryCode;
            }
        }

        /// <summary>
        /// Свойство с проверкой длины кода города
        /// </summary>
        public string CityCode
        {
            set
            {
                if (value.Length != CityCodeLength)
                {
                    throw new ArgumentException("Недостаточная длина кода города");
                }
                _cityCode = value;
            }

            get
            {
                return this._cityCode;
            }
        }

        /// <summary>
        /// Свойство с проверкой длины кода абонента
        /// </summary>
        public string SubscriberCode
        {
            set
            {
                if (value.Length != SubscriberCodeLength)
                {
                    throw new ArgumentException("Недостаточная длина номера абонента");
                }
                _subscriberCode = value;
            }

            get
            {
                return this._subscriberCode;
            }
        }

        /// <summary>
        /// Конструктор принимает строки с кодом страны, города и абонента
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="cityCode"></param>
        /// <param name="subscriberCode"></param>
        public PhoneNumber(string countryCode, string cityCode, string subscriberCode)
        {
            this.CountryCode = countryCode;
            this.CityCode = cityCode;
            this.SubscriberCode = subscriberCode;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneNumber()
        {

        }
    }
}

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
    public class PhoneNumber: IEquatable<PhoneNumber>
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
        private string _countryCode = "";

        /// <summary>
        /// Строка хранящая код города
        /// </summary>
        private string _cityCode = "";

        /// <summary>
        /// Строка хранящая код абонента
        /// </summary>
        private string _subscriberCode= "";

        /// <summary>
        /// Перечисление с типами номеров
        /// </summary>
        private PhoneType _type = PhoneType.Mobile;

        /// <summary>
        /// Метод проверяет наличие букв в номере
        /// </summary>
        /// <param name="forCheck"></param>
        private void IsStringDigit(string forCheck)
        {
            for (int i = 0; i < forCheck.Length; i++)
            {
                if (!Char.IsDigit(forCheck[i]))
                {
                    throw new ArgumentException("The number contains symbols other than numbers");
                }
            }
        }

        /// <summary>
        /// Свойство с проверкой на российский номер
        /// </summary>
        public string CountryCode 
        {
            set 
            {
                IsStringDigit(value);

                if (string.Compare(RussianCountryCode, value) != 0)
                {
                    throw new ArgumentException("Country code must be 7");
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
                IsStringDigit(value);

                if (value.Length != CityCodeLength)
                {
                    throw new ArgumentException("Insufficient length of the area code, it must be equal to " 
                        + CityCodeLength);
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
                IsStringDigit(value);

                if (value.Length != SubscriberCodeLength)
                {
                    throw new ArgumentException("Insufficient length of the subscriber number, the length must be" 
                        + SubscriberCodeLength);
                }
                _subscriberCode = value;
            }

            get
            {
                return this._subscriberCode;
            }
        }
        public PhoneType Type
        {
            set
            {
                if(value is PhoneType)
                {
                    _type = value;
                }
                else
                {
                    throw new ArgumentException("the entered value is not included in the enumeration");
                }
            }
            get
            {
                return _type;
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
        public PhoneNumber(string countryCode, string cityCode, string subscriberCode, PhoneType type)
        {
            this.CountryCode = countryCode;
            this.CityCode = cityCode;
            this.SubscriberCode = subscriberCode;
            this.Type = type;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneNumber()
        {

        }

        public bool Equals(PhoneNumber other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _countryCode == other._countryCode && 
                   _cityCode == other._cityCode && 
                   _subscriberCode == other._subscriberCode &&
                   _type == other._type;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PhoneNumber)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_countryCode != null ? _countryCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_cityCode != null ? _cityCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_subscriberCode != null ? _subscriberCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)_type;
                return hashCode;
            }
        }
    }
}

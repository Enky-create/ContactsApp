using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Contact: ICloneable
    {
        /// <summary>
        /// Константа хранит длину для строк с именем, фамилией и почтой
        /// </summary>
        private const int NameSurnameEmailLength = 50;

        /// <summary>
        /// Константа хранит длину строки с id вконтакте
        /// </summary>
        private const int IdVkontakteLength = 15;

        /// <summary>
        /// Строка хранит имя 
        /// </summary>
        private string _name = "";

        /// <summary>
        /// Строка  хранит фамилию
        /// </summary>
        private string _surname = "";

        /// <summary>
        /// Строка хранит эл.почту
        /// </summary>
        private string _email = "";

        /// <summary>
        /// Объект с номером телефона
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Строка хранит idVkontakte
        /// </summary>
        private string _idVkontakte = "";

        /// <summary>
        /// Поле для даты рожждения минимальная дата : 1.01.1900
        /// </summary>
        private DateTime _birthDate = new DateTime(1900, 1, 1);

        /// <summary>
        /// Реализация интерфейса IClonable
        /// копирует  контакт
        /// </summary>
        /// <returns>возвращает новый объект Contact</returns>
        public object Clone()
        {
            return new Contact( 
                new PhoneNumber(
                this.PhoneNumber.CountryCode, 
                this.PhoneNumber.CityCode, 
                this.PhoneNumber.SubscriberCode),
                this.Name, 
                this.Surname,
                new DateTime(this.BirthDate.Year, this.BirthDate.Month, this.BirthDate.Day),
                this.Email, 
                this.IdVkontakte
                );
            
        }

        /// <summary>
        /// Свойство с проверкой на корректность даты рождения
        /// </summary>
        public DateTime BirthDate
        {
            set
            {
                var minDate = new DateTime(1900,1,1);
               

                if ((value > DateTime.Now)||(value < minDate))
                {
                    throw new ArgumentException("Некорректная дата");
                }
                this._birthDate = value;
            }
            get
            {
                return this._birthDate;
            }
        }

        /// <summary>
        /// Свойство с проверкой длины id. Длина должна быть <= 15 символов
        /// </summary>
        public string IdVkontakte
        {
            set
            {
                if (value.Length > IdVkontakteLength)
                {
                    throw new ArgumentException("IdVkontakte больше 15 символов");
                }
                this._idVkontakte = value;
            }
            get
            {
                return this._idVkontakte;
            }
        }

        /// <summary>
        /// Свойство проверяет длину имени, длина должна быть <=50 символов
        /// </summary>
        public string Name 
        {
            set
            {
                if(value.Length > NameSurnameEmailLength)
                {
                    throw new ArgumentException("Имя больше 50 символов");
                }
                this._name = value;
            } 
            
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Свойство проверяет длину фамилии, длина должна быть <=50 символов
        /// </summary>
        public string Surname
        {
            set
            {
                if (value.Length > NameSurnameEmailLength)
                {
                    throw new ArgumentException("Фамилия больше 50 символов");
                }
                this._surname = value;
            }

            get
            {
                return this._surname;
            }
        }

        /// <summary>
        /// Свойство проверяет длину эл.почты, длина должна быть <=50 символов
        /// </summary>
        public string Email
        {
            set
            {
                if (value.Length > NameSurnameEmailLength)
                {
                    throw new ArgumentException("Email больше 50 символов");
                }
                this._email = value;
            }

            get
            {
                return this._email;
            }
        }

        /// <summary>
        /// Свойство присваивает и возвращает PhoneNumber
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            set
            {
                this._phoneNumber = value;
            }

            get
            {
                return this._phoneNumber;
            }
        }

        /// <summary>
        /// Конструктор с необходимыми данными контакта
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public Contact(PhoneNumber phoneNumber, string name, string surname)
        {
            /*if (phoneNumber.Length != 11)
            {
                throw new ArgumentException("Номер меньше или больше  11 символов");
            }*/
           /* var countryCode = phoneNumber.Substring(0,1);

            var cityCode = phoneNumber.Substring(1, 3);
            
            var subscriberCode = phoneNumber.Substring(4,7);*/

            var corrrectName = name.Substring(0, 1).ToUpper() + name.Substring(1);

            var correctSurname = surname.Substring(0, 1).ToUpper() + surname.Substring(1);

            this.Name = corrrectName;

            this.Surname = correctSurname;

            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Конструктор со всеми данными контакта
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birthDate"></param>
        /// <param name="email"></param>
        /// <param name="idVkontakte"></param>
        public Contact(PhoneNumber phoneNumber, string name, string surname, DateTime birthDate, string email, string idVkontakte)
        {
            var corrrectName = name.Substring(0, 1).ToUpper() + name.Substring(1);

            var correctSurname = surname.Substring(0, 1).ToUpper() + surname.Substring(1);

            this.Email = email;

            this.BirthDate = birthDate;

            this.IdVkontakte = idVkontakte;

            this.Name = corrrectName;

            this.Surname = correctSurname;

            this.PhoneNumber = phoneNumber;
        }

        public Contact()
        {

        }

    }
}

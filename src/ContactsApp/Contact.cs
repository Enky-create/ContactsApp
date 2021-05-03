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
        private PhoneNumber _phoneNumber = new PhoneNumber();

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
                    throw new ArgumentException("Дата не может быть больше текущей и меньше 1.01.1900");
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
                if (value == "")
                {
                    throw new ArgumentException("Длина имени равна "
                        + value.Length
                        + "имя должно быть больше 0");
                }
                this._name = value.Substring(0, 1).ToUpper() + value.Substring(1); 
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
                if (value.Length == 0)
                {
                    throw new ArgumentException("Длина фамилии равна " 
                        + value.Length 
                        + "фамилия должна быть больше 0");
                }
                this._surname = value.Substring(0, 1).ToUpper() + value.Substring(1); 
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
            get; set;
        } = new PhoneNumber();

        /// <summary>
        /// Конструктор с необходимыми данными контакта
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public Contact(PhoneNumber phoneNumber, string name, string surname)
        {
            this.Name = name;

            this.Surname = surname;

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
            this.Email = email;

            this.BirthDate = birthDate;

            this.IdVkontakte = idVkontakte;

            this.Name = name;

            this.Surname = surname;

            this.PhoneNumber = phoneNumber;
        }

        public Contact()
        {

        }

    }
}

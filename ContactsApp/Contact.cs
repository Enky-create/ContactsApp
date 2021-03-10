using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Contact: ICloneable
    {
        private const int NameSurnameEmailLength = 50;

        private const int IdVkontakteLength = 15;

        private string _name = "";

        private string _surname = "";

        private string _email = "";

        private PhoneNumber _phoneNumber;

        private string _idVkontakte = "";

        private DateTime _birthDate = new DateTime(1900, 1, 1);

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

        public Contact(PhoneNumber phoneNumber, string name, string surname, DateTime birthDate, string email, string idVkontakte)
        {
            /*if (phoneNumber.Length != 11)
            {
                throw new ArgumentException("Номер меньше или больше  11 символов");
            }
            var countryCode = phoneNumber.Substring(0, 1);

            var cityCode = phoneNumber.Substring(1, 3);

            var subscriberCode = phoneNumber.Substring(4, 7);*/

            var corrrectName = name.Substring(0, 1).ToUpper() + name.Substring(1);

            var correctSurname = surname.Substring(0, 1).ToUpper() + surname.Substring(1);

            this.Email = email;

            this.BirthDate = birthDate;

            this.IdVkontakte = idVkontakte;

            this.Name = corrrectName;

            this.Surname = correctSurname;

            this.PhoneNumber = phoneNumber;
        }

    }
}

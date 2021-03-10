using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private const string RussianCountryCode = "7";

        private const int CityCodeLength = 3;

        private const int SubscriberCodeLength = 7; 

        private  string _countryCode;

        private string _cityCode;

        private string _subscriberCode;

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

        public PhoneNumber(string countryCode, string cityCode, string subscriberCode)
        {
            this.CountryCode = countryCode;
            this.CityCode = cityCode;
            this.SubscriberCode = subscriberCode;
        }
        public PhoneNumber()
        {

        }
    }
}

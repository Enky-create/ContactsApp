using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private  int _countryCode;
        private int _cityCode;
        private int _subscriberCode;

        public int CountryCode 
        {
            set 
            { 
                if (value != 7)
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

        public int CityCode
        {
            set
            {
                if (value < 100)
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
        public int SubscriberCode
        {
            set
            {
                if (value < 10000000)
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

        PhoneNumber(int countryCode, int cityCode, int subscriberCode)
        {
            this.CountryCode = countryCode;
            this.CityCode = cityCode;
            this.SubscriberCode = subscriberCode;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulationConsole07._01
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        //below ""; allows for an empty string instead of being default of null
        private string phoneNumber = "";
        public string FormattedNumber
        {
            //the get must return a value, which is a string bc that is what is above
            get 
            
            {
                return phoneNumber;
            }
            set 
            {
                phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }


        }
    }
}

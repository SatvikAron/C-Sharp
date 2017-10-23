using System;

namespace PracticeLib
{
    public class Personinformation
    {
        private string Dateofbirth;
        private string Name;
        private string TelePhoneNo;

        public string Greeting {
            get
            {
                //return "1971-04-05;Mattias Asplund;070-6186120";
                return this.Dateofbirth+";"+this.Name+";"+this.TelePhoneNo;
            }
                
                
                }

        public void EnterDetails(string dateofbirth, string name, string telephoneno)
        {
            this.Dateofbirth = dateofbirth;
            this.Name = name;
            this.TelePhoneNo = telephoneno;
        }
    }
}

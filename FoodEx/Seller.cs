using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEx
{
    class Seller
    {
        public static int activeSeller = 0;

        private int id;
        private string name;
        private string password;
        private string telephone_number;
        private string company_name;
        private string address;
        private string image;
        private DateTime join_date;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int value)
        {
            this.id = value;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string value)
        {
            this.name = value;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public void SetPassword(string value)
        {
            this.password = value;
        }
        public string GetTelephone_number()
        {
            return this.telephone_number;
        }
        public void SetTelephone_number(string value)
        {
            this.telephone_number = value;
        }
        public string GetCompany_name()
        {
            return this.company_name;
        }
        public void SetCompany_name(string value)
        {
            this.company_name = value;
        }
        public string GetAdress()
        {
            return this.address;
        }
        public void SetAddress(string value)
        {
            this.address = value;
        }
        public string GetImage()
        {
            return this.image;
        }
        public void SetImage(string value)
        {
            this.image = value;
        }
        public DateTime GetJoin_date()
        {
            return this.join_date;
        }
        public void SetJoin_date(DateTime value)
        {
            this.join_date = value;
        }
    }
}

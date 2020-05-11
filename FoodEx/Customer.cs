using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEx
{
    class Customer
    {
        public static int activeCustomer = 0;

        private int id;
        private string name;
        private string password;
        private string telephone_number;
        private DateTime birth_date;
        private string image;
        private double money;

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
        public DateTime GetBirth_date()
        {
            return this.birth_date;
        }
        public void SetBirth_date(DateTime value)
        {
            this.birth_date = value;
        }
        public string GetImage()
        {
            return this.image;
        }
        public void SetImage(string value)
        {
            this.image = value;
        }
        public double GetMoney()
        {
            return this.money;
        }
        public void SetMoney(double value)
        {
            this.money = value;
        }
    }
}

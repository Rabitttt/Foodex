using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEx
{
    class Product
    {
        private int id;
        private string name;
        private double price;
        private string type;
        private string description;
        private string image;
        private DateTime create_date;
        private int score;
        private Seller owner;

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
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double value)
        {
            this.price = value;
        }
        public string GetType()
        {
            return this.type;
        }
        public void SetType(string value)
        {
            this.type = value;
        }
        public DateTime GetCreate_date()
        {
            return this.create_date;
        }
        public void SetCreate_date(DateTime value)
        {
            this.create_date = value;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public void SetDescription(string value)
        {
            this.description = value;
        }
        public string GetImage()
        {
            return this.image;
        }
        public void SetImage(string value)
        {
            this.image = value;
        }
        public int GetScore()
        {
            return this.score;
        }
        public void SetScore(int value)
        {
            this.score = value;
        }
        public Seller GetOwner()
        {
            return this.owner;
        }
        public void SetOwner(Seller value)
        {
            this.owner = value;
        }
    }
}

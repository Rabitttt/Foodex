using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEx
{
    class Comment
    {
        private int id;
        private string text;
        private DateTime create_time;
        private Product product;
        private Customer customer;
        private Seller seller;


        public int GetId()
        {
            return this.id;
        }
        public void SetId(int value)
        {
            this.id = value;
        }
        public string GetText()
        {
            return this.text;
        }
        public void SetText(string value)
        {
            this.text = value;
        }
        public DateTime GetCreateTime()
        {
            return this.create_time;
        }
        public void SetCreateTime(DateTime value)
        {
            this.create_time = value;
        }
        public Product GetProduct()
        {
            return this.product;
        }
        public void SetProduct(Product value)
        {
            this.product = value;
        }
        public Customer GetCustomer()
        {
            return this.customer;
        }
        public void SetCustomer(Customer value)
        {
            this.customer = value;
        }
        public Seller GetSeller()
        {
            return this.seller;
        }
        public void SetSeller(Seller value)
        {
            this.seller = value;
        }

    }
}

using System;

namespace teste.Entities
{
    public class UsedProduct : Product
    {
        public DateTime Manufacturedate { get; set; }

        public UsedProduct(){}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            this.Manufacturedate = manufactureDate;
        }

        public override string priceTag()
        {
            return ($"{this.Name} (used) $ {this.Price.ToString("F2")} (Manufacture date: {this.Manufacturedate.ToShortDateString()})");
        }
    }
}
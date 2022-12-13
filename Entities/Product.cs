namespace teste.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){}

        public Product(string name, double price) 
        {
            this.Name = name;
            this.Price = price;
   
        }

        public virtual string priceTag(){
            return ($"{this.Name} $ {this.Price.ToString("F2")}");
        }
    }
}
namespace teste.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(){}

        public ImportedProduct(string name, double price, double customsFee) : base (name, price){
            this.CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return ($"{this.Name} $ {totalPrice().ToString("F2")} (Customs fee: $ {this.CustomsFee.ToString("F2")})");
        }

        public double totalPrice(){
            return this.CustomsFee + this.Price;
        }
    }
}
namespace Course
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValueInStock()
        {
            return Quantity * Price;
        }

        public void AddProducts(int quantity){
            Quantity += quantity;
        }
        public void RemoveProducts(int quantity){
            Quantity -= quantity;
        }

        override public string ToString()
        {
            return Name + ", $ "
            + Price.ToString("F2")
            + ", Quantity: "
            + Quantity
            + ", Total value in stock: $"
            + TotalValueInStock();
        }
    }
}
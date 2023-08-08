namespace WarehouseWorkshop
{
    public class Basket
    {
        public List<Stock> Items { get; set; }
        public decimal TotalPrice { get; }

        public Basket(List<Stock> items, decimal totalPrice)
        {
            Items = items;
            TotalPrice = totalPrice;
        }

    }
}
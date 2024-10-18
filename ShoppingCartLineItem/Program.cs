namespace ShoppingCartLineItem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shirt = new Product(101, "Shirt", 500, 10);
            var watch = new Product(102, "Watch", 500, 10);
            var bag = new Product(103, "Bag", 400, 10);
            var mobile = new Product(104, "Mobile", 16000, 10);

            
            var lineItem1 = new LineItem(201, 2, shirt);
            var lineItem2 = new LineItem(202, 2, watch);
            var lineItem3 = new LineItem(203, 2, bag);
            var lineItem4 = new LineItem(204, 2, mobile);

            
            var order1 = new Order(1001, new DateTime(2024, 10, 18), new List<LineItem> { lineItem1, lineItem2 });
            var order2 = new Order(1002, new DateTime(2024, 10, 18), new List<LineItem> { lineItem3, lineItem4 });

            
            var customer = new Customer(101, "Shrikanth", new List<Order> { order1, order2 });

            
            customer.DisplayCustomerDetails();
        }
    }
    
}

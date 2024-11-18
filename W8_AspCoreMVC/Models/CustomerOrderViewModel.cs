namespace W8_AspCoreMVC.Models;

public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
}
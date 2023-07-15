using MauiApp6.MVVM.Models;

namespace MauiApp6.MVVM.ViewModels;

public class CustomersViewModel
{
    public List<Customer> Customers { get; set; } = new List<Customer>();

    public CustomersViewModel()
    {
        Customers.Add(new Customer
        {
            Name = "Fred Flintstone",
            Street = "222 Rocky Way",
            City = "Bedrock",
            State = "LA",
            ZipCode = 70777,
            Phone = "800-555-1212",
            BirthDay = new DateTime(2000, 2, 2),
            ContactTime = new TimeSpan(12,0,0),
            Balance = 0,
            ActiveCustomer = true
        });
    }
}

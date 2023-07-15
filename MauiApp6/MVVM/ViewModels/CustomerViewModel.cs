using MauiApp6.MVVM.Models;

namespace MauiApp6.MVVM.ViewModels;

public class CustomerViewModel
{
    public Customer Customer { get; set; }

    public CustomerViewModel()
    {
        Customer = new Customer
        {
            Name = "Sam Smith",
            Street = "123 Main St",
            City = "Pittsburgh",
            State = "PA",
            ZipCode = 70888,
            Phone = "412-555-1212",
            BirthDay = new DateTime(1990, 12, 20),
            ContactTime = new TimeSpan(12, 0, 0),
            Balance = 123.45,
            ActiveCustomer = true
        };
    }
}

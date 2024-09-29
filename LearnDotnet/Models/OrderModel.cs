using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearnDotnet.Models;

public class OrderModel
{
    public int OrderID { get; set; }
    public string Status { get; set; }
}

public enum OrderStatus
{
    [Display(Name="Open")]
    Open,
    [Display(Name="Procurement")]
    Procurement,
    [Display(Name="Production")] 
    Production,
    [Display(Name="Fulfilled")]
    Fulfilled
}
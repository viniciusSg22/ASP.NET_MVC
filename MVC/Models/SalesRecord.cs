using MVC.Models.Enums;
using MVC.Models.Logs;

namespace MVC.Models;

public class SalesRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public SaleStatus Status { get; set; }
    public Seller Seller { get; set; }
    public ICollection<SalesLog> SalesLog { get; set; } = new List<SalesLog>();

    public SalesRecord()
    {
    }

    public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
    {
        Id = id;
        Date = date;
        Amount = amount;
        Status = status;
        Seller = seller;
    }
}
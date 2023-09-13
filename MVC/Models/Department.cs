namespace MVC.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

    public Department()
    {
    }

    public Department(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }

    public void AddSeller(Seller seller)
    {
        Sellers.Add(seller);
    }

    public double TotalSales(DateTime initial, DateTime final)
    {
        //NON-LINQ
        //double totalSales = 0;
        //foreach (Seller seller in Sellers)
        //{
        //    totalSales += seller.TotalSales(initial, final);
        //}
        //return totalSales;

        //LINQ
        return Sellers.Sum(seller => seller.TotalSales(initial, final));
    }
}
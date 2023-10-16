using MVC.Data;
using MVC.Models;

namespace MVC.Services;

public class SellerService
{
    private readonly MVCContext _context;

    public SellerService(MVCContext context)
    {
        _context = context;
    }

    public List<Seller> FindAll()
    {
        return _context.Sellers.ToList();
    }

    public void Insert(Seller seller)
    {
        _context.Add(seller);
        _context.SaveChanges();
    }

    public Seller FindById(int id)
    {
        return _context.Sellers.FirstOrDefault(x => x.Id == id);
    }

    public void Delete(int id)
    {
        var obj = _context.Sellers.Find(id);
        _context.Remove(obj);
        _context.SaveChanges();
    }
}
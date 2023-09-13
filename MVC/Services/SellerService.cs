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
}

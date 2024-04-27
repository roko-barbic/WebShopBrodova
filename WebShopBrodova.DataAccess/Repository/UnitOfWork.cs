using WebShopBrodova.DataAccess.Data;
using WebShopBrodova.DataAccess.Repository.IRepository;

namespace WebShopBrodova.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private ApplicationDbContext _context;
    public ITypeOfBoatRepository TypeOfBoat { get; set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        TypeOfBoat = new TypeOfBoatRepositoy(_context);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
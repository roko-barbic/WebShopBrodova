using WebShopBrodova.DataAccess.Data;
using WebShopBrodova.DataAccess.Repository.IRepository;
using WebShopBrodova.Models.Models;

namespace WebShopBrodova.DataAccess.Repository;

public class TypeOfBoatRepositoy : Repository<TypeBoat>, ITypeOfBoatRepository
{
    private ApplicationDbContext _context;

    public TypeOfBoatRepositoy(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public void Update(TypeBoat typeBoat)
    {
        _context.Update(typeBoat);
    }
    
}
using WebShopBrodova.Models.Models;

namespace WebShopBrodova.DataAccess.Repository.IRepository;

public interface ITypeOfBoatRepository : IRepository<TypeBoat>
{
    void Update(TypeBoat typeBoat);
}